using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Store;
using UnityEngine.UI;

[AddComponentMenu("Unity IAP/Demo")]
public class IAPDemo : MonoBehaviour, IStoreListener
{
	[Serializable]
	public class UnityChannelPurchaseError
	{
		public string error;

		public UnityChannelPurchaseInfo purchaseInfo;
	}

	[Serializable]
	public class UnityChannelPurchaseInfo
	{
		public string productCode;

		public string gameOrderId;

		public string orderQueryToken;
	}

	private class UnityChannelLoginHandler : ILoginListener
	{
		internal Action initializeSucceededAction;

		internal Action<string> initializeFailedAction;

		internal Action<UserInfo> loginSucceededAction;

		internal Action<string> loginFailedAction;

		public void OnInitialized()
		{
			initializeSucceededAction();
		}

		public void OnInitializeFailed(string message)
		{
			initializeFailedAction(message);
		}

		public void OnLogin(UserInfo userInfo)
		{
			loginSucceededAction(userInfo);
		}

		public void OnLoginFailed(string message)
		{
			loginFailedAction(message);
		}
	}

	private IStoreController m_Controller;

	private IAppleExtensions m_AppleExtensions;

	private IMoolahExtension m_MoolahExtensions;

	private ISamsungAppsExtensions m_SamsungExtensions;

	private IMicrosoftExtensions m_MicrosoftExtensions;

	private IUnityChannelExtensions m_UnityChannelExtensions;

	private ITransactionHistoryExtensions m_TransactionHistoryExtensions;

	private bool m_IsGooglePlayStoreSelected;

	private bool m_IsSamsungAppsStoreSelected;

	private bool m_IsCloudMoolahStoreSelected;

	private bool m_IsUnityChannelSelected;

	private string m_LastTransactionID;

	private bool m_IsLoggedIn;

	private UnityChannelLoginHandler unityChannelLoginHandler;

	private bool m_FetchReceiptPayloadOnPurchase;

	private bool m_PurchaseInProgress;

	private Dictionary<string, IAPDemoProductUI> m_ProductUIs = new Dictionary<string, IAPDemoProductUI>();

	public GameObject productUITemplate;

	public RectTransform contentRect;

	public Button restoreButton;

	public Button loginButton;

	public Button validateButton;

	public Text versionText;

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
		m_Controller = controller;
		m_AppleExtensions = extensions.GetExtension<IAppleExtensions>();
		m_SamsungExtensions = extensions.GetExtension<ISamsungAppsExtensions>();
		m_MoolahExtensions = extensions.GetExtension<IMoolahExtension>();
		m_MicrosoftExtensions = extensions.GetExtension<IMicrosoftExtensions>();
		m_UnityChannelExtensions = extensions.GetExtension<IUnityChannelExtensions>();
		m_TransactionHistoryExtensions = extensions.GetExtension<ITransactionHistoryExtensions>();
		InitUI(controller.products.all);
		m_AppleExtensions.RegisterPurchaseDeferredListener((Action<Product>)OnDeferred);
		Debug.Log((object)"Available items:");
		Product[] all = controller.products.all;
		foreach (Product val in all)
		{
			if (val.availableToPurchase)
			{
				Debug.Log((object)string.Join(" - ", val.metadata.localizedTitle, val.metadata.localizedDescription, val.metadata.isoCurrencyCode, val.metadata.localizedPrice.ToString(), val.metadata.localizedPriceString, val.transactionID, val.receipt));
			}
		}
		AddProductUIs(m_Controller.products.all);
		LogProductDefinitions();
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
	{
		Debug.Log((object)("Purchase OK: " + e.purchasedProduct.definition.id));
		Debug.Log((object)("Receipt: " + e.purchasedProduct.receipt));
		m_LastTransactionID = e.purchasedProduct.transactionID;
		m_PurchaseInProgress = false;
		if (m_IsUnityChannelSelected)
		{
			UnifiedReceipt val = JsonUtility.FromJson<UnifiedReceipt>(e.purchasedProduct.receipt);
			if (val != null && !string.IsNullOrEmpty(val.Payload))
			{
				UnityChannelPurchaseReceipt val2 = JsonUtility.FromJson<UnityChannelPurchaseReceipt>(val.Payload);
				Debug.LogFormat("UnityChannel receipt: storeSpecificId = {0}, transactionId = {1}, orderQueryToken = {2}", new object[3] { val2.storeSpecificId, val2.transactionId, val2.orderQueryToken });
			}
		}
		UpdateProductUI(e.purchasedProduct);
		return (PurchaseProcessingResult)0;
	}

	public void OnPurchaseFailed(Product item, PurchaseFailureReason r)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Invalid comparison between Unknown and I4
		Debug.Log((object)("Purchase failed: " + item.definition.id));
		Debug.Log((object)r);
		Debug.Log((object)("Store specific error code: " + ((object)m_TransactionHistoryExtensions.GetLastStoreSpecificPurchaseErrorCode()/*cast due to constrained. prefix*/).ToString()));
		if (m_TransactionHistoryExtensions.GetLastPurchaseFailureDescription() != null)
		{
			Debug.Log((object)("Purchase failure description message: " + m_TransactionHistoryExtensions.GetLastPurchaseFailureDescription().message));
		}
		if (m_IsUnityChannelSelected)
		{
			UnityChannelPurchaseError unityChannelPurchaseError = JsonUtility.FromJson<UnityChannelPurchaseError>(m_UnityChannelExtensions.GetLastPurchaseError());
			if (unityChannelPurchaseError != null && unityChannelPurchaseError.purchaseInfo != null)
			{
				UnityChannelPurchaseInfo purchaseInfo = unityChannelPurchaseError.purchaseInfo;
				Debug.LogFormat("UnityChannel purchaseInfo: productCode = {0}, gameOrderId = {1}, orderQueryToken = {2}", new object[3] { purchaseInfo.productCode, purchaseInfo.gameOrderId, purchaseInfo.orderQueryToken });
			}
			if ((int)r == 6)
			{
				Debug.Log((object)"Duplicate transaction detected, unlock this item");
			}
		}
		m_PurchaseInProgress = false;
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I4, but got Unknown
		Debug.Log((object)"Billing failed to initialize!");
		switch ((int)error)
		{
		case 2:
			Debug.LogError((object)"Is your App correctly uploaded on the relevant publisher console?");
			break;
		case 0:
			Debug.Log((object)"Billing disabled!");
			break;
		case 1:
			Debug.Log((object)"No products available for purchase!");
			break;
		}
	}

	public void Awake()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Invalid comparison between Unknown and I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Invalid comparison between Unknown and I4
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Invalid comparison between Unknown and I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		StandardPurchasingModule val = StandardPurchasingModule.Instance();
		val.useFakeStoreUIMode = (FakeStoreUIMode)1;
		ConfigurationBuilder builder = ConfigurationBuilder.Instance((IPurchasingModule)(object)val, Array.Empty<IPurchasingModule>());
		builder.Configure<IMicrosoftConfiguration>().useMockBillingSystem = false;
		m_IsGooglePlayStoreSelected = (int)Application.platform == 11 && (int)val.appStore == 1;
		builder.Configure<IMoolahConfiguration>().appKey = "d93f4564c41d463ed3d3cd207594ee1b";
		builder.Configure<IMoolahConfiguration>().hashKey = "cc";
		builder.Configure<IMoolahConfiguration>().SetMode((CloudMoolahMode)1);
		m_IsCloudMoolahStoreSelected = (int)Application.platform == 11 && (int)val.appStore == 3;
		m_IsUnityChannelSelected = (int)Application.platform == 11 && (int)val.appStore == 5;
		builder.Configure<IUnityChannelConfiguration>().fetchReceiptPayloadOnPurchase = m_FetchReceiptPayloadOnPurchase;
		foreach (ProductCatalogItem allValidProduct in ProductCatalog.LoadDefaultCatalog().allValidProducts)
		{
			if (allValidProduct.allStoreIDs.Count > 0)
			{
				IDs val2 = new IDs();
				foreach (StoreID allStoreID in allValidProduct.allStoreIDs)
				{
					val2.Add(allStoreID.id, new string[1] { allStoreID.store });
				}
				builder.AddProduct(allValidProduct.id, allValidProduct.type, val2);
			}
			else
			{
				builder.AddProduct(allValidProduct.id, allValidProduct.type);
			}
		}
		ConfigurationBuilder val3 = builder;
		IDs val4 = new IDs();
		val4.Add("com.unity3d.unityiap.unityiapdemo.100goldcoins.7", new string[1] { "MacAppStore" });
		val4.Add("000000596586", new string[1] { "TizenStore" });
		val4.Add("com.ff", new string[1] { "MoolahAppStore" });
		val4.Add("100.gold.coins", new string[1] { "AmazonApps" });
		val3.AddProduct("100.gold.coins", (ProductType)0, val4);
		ConfigurationBuilder val5 = builder;
		val4 = new IDs();
		val4.Add("com.unity3d.unityiap.unityiapdemo.500goldcoins.7", new string[1] { "MacAppStore" });
		val4.Add("000000596581", new string[1] { "TizenStore" });
		val4.Add("com.ee", new string[1] { "MoolahAppStore" });
		val4.Add("500.gold.coins", new string[1] { "AmazonApps" });
		val5.AddProduct("500.gold.coins", (ProductType)0, val4);
		ConfigurationBuilder val6 = builder;
		val4 = new IDs();
		val4.Add("com.unity3d.unityiap.unityiapdemo.sword.7", new string[1] { "MacAppStore" });
		val4.Add("000000596583", new string[1] { "TizenStore" });
		val4.Add("sword", new string[1] { "AmazonApps" });
		val6.AddProduct("sword", (ProductType)1, val4);
		builder.Configure<ISamsungAppsConfiguration>().SetMode((SamsungAppsMode)1);
		m_IsSamsungAppsStoreSelected = (int)Application.platform == 11 && (int)val.appStore == 4;
		builder.Configure<ITizenStoreConfiguration>().SetGroupId("100000085616");
		Action initializeUnityIap = () =>
		{
			UnityPurchasing.Initialize((IStoreListener)(object)this, builder);
		};
		if (!m_IsUnityChannelSelected)
		{
			initializeUnityIap();
			return;
		}
		AppInfo val7 = new AppInfo
		{
			appId = "abc123appId",
			appKey = "efg456appKey",
			clientId = "hij789clientId",
			clientKey = "klm012clientKey",
			debug = false
		};
		unityChannelLoginHandler = new UnityChannelLoginHandler();
		unityChannelLoginHandler.initializeFailedAction = (string message) =>
		{
			Debug.LogError((object)("Failed to initialize and login to UnityChannel: " + message));
		};
		unityChannelLoginHandler.initializeSucceededAction = () =>
		{
			initializeUnityIap();
		};
		StoreService.Initialize(val7, (ILoginListener)(object)unityChannelLoginHandler);
	}

	private void OnTransactionsRestored(bool success)
	{
		Debug.Log((object)"Transactions restored.");
	}

	private void OnDeferred(Product item)
	{
		Debug.Log((object)("Purchase deferred: " + item.definition.id));
	}

	private void InitUI(IEnumerable<Product> items)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		((Component)restoreButton).gameObject.SetActive(NeedRestoreButton());
		((Component)loginButton).gameObject.SetActive(NeedLoginButton());
		((Component)validateButton).gameObject.SetActive(NeedValidateButton());
		ClearProductUIs();
		((UnityEvent)restoreButton.onClick).AddListener((UnityAction)RestoreButtonClick);
		((UnityEvent)loginButton.onClick).AddListener((UnityAction)LoginButtonClick);
		((UnityEvent)validateButton.onClick).AddListener((UnityAction)ValidateButtonClick);
		versionText.text = "Unity version: " + Application.unityVersion + "\nIAP version: 1.20.1";
	}

	public void PurchaseButtonClick(string productID)
	{
		if (m_PurchaseInProgress)
		{
			Debug.Log((object)"Please wait, purchase in progress");
			return;
		}
		if (m_Controller == null)
		{
			Debug.LogError((object)"Purchasing is not initialized");
			return;
		}
		if (m_Controller.products.WithID(productID) == null)
		{
			Debug.LogError((object)("No product has id " + productID));
			return;
		}
		if (NeedLoginButton() && !m_IsLoggedIn)
		{
			Debug.LogWarning((object)"Purchase notifications will not be forwarded server-to-server. Login incomplete.");
		}
		m_PurchaseInProgress = true;
		m_Controller.InitiatePurchase(m_Controller.products.WithID(productID), "aDemoDeveloperPayload");
	}

	public void RestoreButtonClick()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		if (m_IsCloudMoolahStoreSelected)
		{
			if (!m_IsLoggedIn)
			{
				Debug.LogError((object)"CloudMoolah purchase restoration aborted. Login incomplete.");
				return;
			}
			m_MoolahExtensions.RestoreTransactionID((Action<RestoreTransactionIDState>)((RestoreTransactionIDState restoreTransactionIDState) =>
			{
				//IL_001c: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Invalid comparison between Unknown and I4
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0022: Invalid comparison between Unknown and I4
				Debug.Log((object)("restoreTransactionIDState = " + ((object)restoreTransactionIDState/*cast due to constrained. prefix*/).ToString()));
				bool success = (int)restoreTransactionIDState != 2 && (int)restoreTransactionIDState != 3;
				OnTransactionsRestored(success);
			}));
		}
		else if (m_IsSamsungAppsStoreSelected)
		{
			m_SamsungExtensions.RestoreTransactions((Action<bool>)OnTransactionsRestored);
		}
		else if ((int)Application.platform == 18 || (int)Application.platform == 19 || (int)Application.platform == 20)
		{
			m_MicrosoftExtensions.RestoreTransactions();
		}
		else
		{
			m_AppleExtensions.RestoreTransactions((Action<bool>)OnTransactionsRestored);
		}
	}

	public void LoginButtonClick()
	{
		if (!m_IsUnityChannelSelected)
		{
			Debug.Log((object)"Login is only required for the Xiaomi store");
			return;
		}
		unityChannelLoginHandler.loginSucceededAction = (UserInfo userInfo) =>
		{
			m_IsLoggedIn = true;
			Debug.LogFormat("Succeeded logging into UnityChannel. channel {0}, userId {1}, userLoginToken {2} ", new object[3] { userInfo.channel, userInfo.userId, userInfo.userLoginToken });
		};
		unityChannelLoginHandler.loginFailedAction = (string message) =>
		{
			m_IsLoggedIn = false;
			Debug.LogError((object)("Failed logging into UnityChannel. " + message));
		};
		StoreService.Login((ILoginListener)(object)unityChannelLoginHandler);
	}

	public void ValidateButtonClick()
	{
		if (!m_IsUnityChannelSelected)
		{
			Debug.Log((object)"Remote purchase validation is only supported for the Xiaomi store");
			return;
		}
		string txId = m_LastTransactionID;
		m_UnityChannelExtensions.ValidateReceipt(txId, (Action<bool, string, string>)((bool success, string signData, string signature) =>
		{
			Debug.LogFormat("ValidateReceipt transactionId {0}, success {1}, signData {2}, signature {3}", new object[4] { txId, success, signData, signature });
		}));
	}

	private void ClearProductUIs()
	{
		foreach (KeyValuePair<string, IAPDemoProductUI> productUI in m_ProductUIs)
		{
			Object.Destroy((Object)(object)((Component)productUI.Value).gameObject);
		}
		m_ProductUIs.Clear();
	}

	private void AddProductUIs(Product[] products)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		ClearProductUIs();
		RectTransform component = productUITemplate.GetComponent<RectTransform>();
		Rect rect = component.rect;
		float height = rect.height;
		Vector3 val = ((Transform)component).localPosition;
		contentRect.SetSizeWithCurrentAnchors((Axis)1, (float)products.Length * height);
		foreach (Product val2 in products)
		{
			GameObject val3 = Object.Instantiate<GameObject>(productUITemplate.gameObject);
			val3.transform.SetParent(productUITemplate.transform.parent, false);
			((Transform)val3.GetComponent<RectTransform>()).localPosition = val;
			val += Vector3.down * height;
			val3.SetActive(true);
			IAPDemoProductUI component2 = val3.GetComponent<IAPDemoProductUI>();
			component2.SetProduct(val2, PurchaseButtonClick);
			m_ProductUIs[val2.definition.id] = component2;
		}
	}

	private void UpdateProductUI(Product p)
	{
		if (m_ProductUIs.ContainsKey(p.definition.id))
		{
			m_ProductUIs[p.definition.id].SetProduct(p, PurchaseButtonClick);
		}
	}

	private void UpdateProductPendingUI(Product p, int secondsRemaining)
	{
		if (m_ProductUIs.ContainsKey(p.definition.id))
		{
			m_ProductUIs[p.definition.id].SetPendingTime(secondsRemaining);
		}
	}

	private bool NeedRestoreButton()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		if ((int)Application.platform != 8 && (int)Application.platform != 1 && (int)Application.platform != 31 && (int)Application.platform != 18 && (int)Application.platform != 19 && (int)Application.platform != 20 && !m_IsSamsungAppsStoreSelected)
		{
			return m_IsCloudMoolahStoreSelected;
		}
		return true;
	}

	private bool NeedLoginButton()
	{
		return m_IsUnityChannelSelected;
	}

	private bool NeedValidateButton()
	{
		return m_IsUnityChannelSelected;
	}

	private void LogProductDefinitions()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		Product[] all = m_Controller.products.all;
		foreach (Product val in all)
		{
			Debug.Log((object)string.Format("id: {0}\nstore-specific id: {1}\ntype: {2}\nenabled: {3}\n", val.definition.id, val.definition.storeSpecificId, ((object)val.definition.type/*cast due to constrained. prefix*/).ToString(), (!val.definition.enabled) ? "disabled" : "enabled"));
		}
	}
}
