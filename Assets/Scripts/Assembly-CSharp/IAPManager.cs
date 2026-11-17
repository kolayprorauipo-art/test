using System;
using System.Collections.Generic;
using System.Linq;
using GleyEasyIAP;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Security;

public class IAPManager : IStoreListener
{
	internal bool debug;

	private static IStoreController m_StoreController;

	private static IExtensionProvider m_StoreExtensionProvider;

	private List<StoreProduct> shopProducts;

	private ConfigurationBuilder builder;

	private UnityAction<IAPOperationStatus, string, List<StoreProduct>> OnInitComplete;

	private UnityAction<IAPOperationStatus, string, StoreProduct> OnCompleteMethod;

	private static IAPManager instance;

	public static IAPManager Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new IAPManager();
			}
			return instance;
		}
	}

	public void InitializeIAPManager(UnityAction<IAPOperationStatus, string, List<StoreProduct>> InitComplete)
	{
		IAPSettings iAPSettings = Resources.Load<IAPSettings>("IAPData");
		if ((Object)(object)iAPSettings == (Object)null)
		{
			Debug.LogError((object)"No products available -> Go to Window->Gley->Easy IAP and define your products");
			return;
		}
		shopProducts = iAPSettings.shopProducts;
		debug = iAPSettings.debug;
		if (debug)
		{
			Debug.Log((object)string.Concat(this, "Initialization Started"));
			ScreenWriter.Write(string.Concat(this, "Initialization Started"));
		}
		if (m_StoreController == null)
		{
			OnInitComplete = InitComplete;
			InitializePurchasing();
		}
	}

	public bool IsInitialized()
	{
		if (m_StoreController != null)
		{
			return m_StoreExtensionProvider != null;
		}
		return false;
	}

	public void BuyProduct(ShopProductNames productName, UnityAction<IAPOperationStatus, string, StoreProduct> OnCompleteMethod)
	{
		if (debug)
		{
			Debug.Log((object)string.Concat(this, "Buy Process Started for ", productName));
			ScreenWriter.Write(string.Concat(this, "Buy Process Started for ", productName));
		}
		this.OnCompleteMethod = OnCompleteMethod;
		for (int i = 0; i < shopProducts.Count; i++)
		{
			if (shopProducts[i].productName == productName.ToString())
			{
				BuyProductID(shopProducts[i].GetStoreID());
			}
		}
	}

	public void RestorePurchases(UnityAction<IAPOperationStatus, string, StoreProduct> OnCompleteMethod)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (!IsInitialized())
		{
			if (debug)
			{
				Debug.Log((object)string.Concat(this, "RestorePurchases FAIL. Not initialized."));
				ScreenWriter.Write(string.Concat(this, "RestorePurchases FAIL. Not initialized."));
			}
		}
		else if ((int)Application.platform == 8 || (int)Application.platform == 1)
		{
			if (debug)
			{
				Debug.Log((object)string.Concat(this, "RestorePurchases started ..."));
				ScreenWriter.Write(string.Concat(this, "RestorePurchases started ..."));
			}
			this.OnCompleteMethod = OnCompleteMethod;
			m_StoreExtensionProvider.GetExtension<IAppleExtensions>().RestoreTransactions((Action<bool>)((bool result) =>
			{
				if (debug)
				{
					Debug.Log((object)string.Concat(this, "RestorePurchases continuing: ", result, ". If no further messages, no purchases available to restore."));
					ScreenWriter.Write(string.Concat(this, "RestorePurchases continuing: ", result, ". If no further messages, no purchases available to restore."));
				}
			}));
		}
		else if (debug)
		{
			Debug.Log((object)string.Concat(this, "RestorePurchases FAIL. Not supported on this platform. Current = ", Application.platform));
			ScreenWriter.Write(string.Concat(this, "RestorePurchases FAIL. Not supported on this platform. Current = ", Application.platform));
		}
	}

	public ProductType GetProductType(ShopProductNames product)
	{
		if (IsInitialized())
		{
			return shopProducts.First((StoreProduct cond) => string.Equals(cond.productName, product.ToString())).productType;
		}
		Debug.LogError((object)"Not Initialized -> Call IAPManager.Instance.InitializeIAPManager() before anything else");
		return ProductType.Consumable;
	}

	public int GetValue(ShopProductNames product)
	{
		if (IsInitialized())
		{
			return shopProducts.First((StoreProduct cond) => string.Equals(cond.productName, product.ToString())).value;
		}
		Debug.LogError((object)"Not Initialized -> Call IAPManager.Instance.InitializeIAPManager() before anything else");
		return 0;
	}

	public string GetLocalizedPriceString(ShopProductNames product)
	{
		if (IsInitialized())
		{
			if (shopProducts != null)
			{
				return shopProducts.First((StoreProduct cond) => string.Equals(cond.productName, product.ToString())).localizedPriceString;
			}
			Debug.LogError((object)"No products available -> Go to Window->Gley->Easy IAP and define your products");
		}
		else
		{
			Debug.LogError((object)"Not Initialized -> Call IAPManager.Instance.InitializeIAPManager() before anything else");
		}
		return "-";
	}

	public int GetPrice(ShopProductNames product)
	{
		if (IsInitialized())
		{
			return shopProducts.First((StoreProduct cond) => string.Equals(cond.productName, product.ToString())).price;
		}
		Debug.LogError((object)"Not Initialized -> Call IAPManager.Instance.InitializeIAPManager() before anything else");
		return 0;
	}

	public string GetIsoCurrencyCode(ShopProductNames product)
	{
		if (IsInitialized())
		{
			return shopProducts.First((StoreProduct cond) => string.Equals(cond.productName, product.ToString())).isoCurrencyCode;
		}
		Debug.LogError((object)"Not Initialized -> Call IAPManager.Instance.InitializeIAPManager() before anything else");
		return "-";
	}

	public string GetLocalizedDescription(ShopProductNames product)
	{
		if (IsInitialized())
		{
			return shopProducts.First((StoreProduct cond) => string.Equals(cond.productName, product.ToString())).localizedDescription;
		}
		Debug.LogError((object)"Not Initialized -> Call IAPManager.Instance.InitializeIAPManager() before anything else");
		return "-";
	}

	public string GetLocalizedTitle(ShopProductNames product)
	{
		if (IsInitialized())
		{
			return shopProducts.First((StoreProduct cond) => string.Equals(cond.productName, product.ToString())).localizedTitle;
		}
		Debug.LogError((object)"Not Initialized -> Call IAPManager.Instance.InitializeIAPManager() before anything else");
		return "-";
	}

	public bool IsActive(ShopProductNames product)
	{
		if (IsInitialized())
		{
			return shopProducts.First((StoreProduct cond) => string.Equals(cond.productName, product.ToString())).active;
		}
		Debug.LogError((object)"Not Initialized -> Call IAPManager.Instance.InitializeIAPManager() before anything else");
		return false;
	}

	public ShopProductNames ConvertNameToShopProduct(string name)
	{
		return (ShopProductNames)Enum.Parse(typeof(ShopProductNames), name);
	}

	private void BuyProductID(string productId)
	{
		if (debug)
		{
			Debug.Log((object)string.Concat(this, "Buy product with id: ", productId));
			ScreenWriter.Write(string.Concat(this, "Buy product with id: ", productId));
		}
		if (IsInitialized())
		{
			Product val = m_StoreController.products.WithID(productId);
			if (val != null && val.availableToPurchase)
			{
				m_StoreController.InitiatePurchase(val);
				return;
			}
			if (debug)
			{
				Debug.Log((object)string.Concat(this, "BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase"));
				ScreenWriter.Write(string.Concat(this, "BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase"));
			}
			if (OnCompleteMethod != null)
			{
				OnCompleteMethod.Invoke(IAPOperationStatus.Fail, "Not purchasing product, either is not found or is not available for purchase", (StoreProduct)null);
			}
		}
		else
		{
			if (debug)
			{
				Debug.Log((object)string.Concat(this, "BuyProductID FAIL. Store not initialized."));
				ScreenWriter.Write(string.Concat(this, "BuyProductID FAIL. Store not initialized."));
			}
			if (OnCompleteMethod != null)
			{
				OnCompleteMethod.Invoke(IAPOperationStatus.Fail, "Store not initialized.", (StoreProduct)null);
			}
		}
	}

	private void InitializePurchasing()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (IsInitialized())
		{
			OnInitComplete.Invoke(IAPOperationStatus.Success, "Already initialized", (List<StoreProduct>)null);
			return;
		}
		builder = ConfigurationBuilder.Instance((IPurchasingModule)(object)StandardPurchasingModule.Instance(), Array.Empty<IPurchasingModule>());
		for (int i = 0; i < shopProducts.Count; i++)
		{
			builder.AddProduct(shopProducts[i].GetStoreID(), shopProducts[i].GetProductType());
		}
		UnityPurchasing.Initialize((IStoreListener)(object)this, builder);
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
		m_StoreController = controller;
		m_StoreExtensionProvider = extensions;
		for (int i = 0; i < shopProducts.Count; i++)
		{
			Product val = m_StoreController.products.WithID(shopProducts[i].GetStoreID());
			if (debug)
			{
				Debug.Log((object)string.Concat(this, val.metadata.localizedTitle, " is available ", val.availableToPurchase));
				ScreenWriter.Write(string.Concat(this, val.metadata.localizedTitle, " is available ", val.availableToPurchase));
			}
			if (shopProducts[i].productType == ProductType.Subscription && val != null && val.hasReceipt && ReceiptIsValid(shopProducts[i].productName, val.receipt, out var _))
			{
				shopProducts[i].active = true;
			}
			if (shopProducts[i].productType == ProductType.NonConsumable && val != null && val.hasReceipt && ReceiptIsValid(shopProducts[i].productName, val.receipt, out var _))
			{
				shopProducts[i].active = true;
			}
			if (val != null && val.availableToPurchase)
			{
				shopProducts[i].localizedPriceString = val.metadata.localizedPriceString;
				shopProducts[i].price = decimal.ToInt32(val.metadata.localizedPrice);
				shopProducts[i].isoCurrencyCode = val.metadata.isoCurrencyCode;
				shopProducts[i].localizedDescription = val.metadata.localizedDescription;
				shopProducts[i].localizedTitle = val.metadata.localizedTitle;
			}
		}
		OnInitComplete.Invoke(IAPOperationStatus.Success, "Success", shopProducts);
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
		OnInitComplete.Invoke(IAPOperationStatus.Fail, ((object)error/*cast due to constrained. prefix*/).ToString(), (List<StoreProduct>)null);
	}

	public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (debug)
		{
			Debug.Log((object)string.Concat(this, "Buy Product failed for ", product.metadata.localizedTitle, " Failed. Reason: ", reason));
			ScreenWriter.Write(string.Concat(this, "Buy Product failed for ", product.metadata.localizedTitle, " Failed. Reason: ", reason));
		}
		if (OnCompleteMethod != null)
		{
			OnCompleteMethod.Invoke(IAPOperationStatus.Fail, product.metadata.localizedTitle + " Failed. Reason: " + ((object)reason/*cast due to constrained. prefix*/).ToString(), (StoreProduct)null);
		}
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
	{
		if (debug)
		{
			Debug.Log((object)string.Concat(this, "Product bought ", e.purchasedProduct.definition.id));
			ScreenWriter.Write(string.Concat(this, "Product bought ", e.purchasedProduct.definition.id));
		}
		for (int i = 0; i < shopProducts.Count; i++)
		{
			if (!string.Equals(e.purchasedProduct.definition.id, shopProducts[i].GetStoreID(), StringComparison.Ordinal))
			{
				continue;
			}
			if (ReceiptIsValid(shopProducts[i].productName, e.purchasedProduct.receipt, out var exception))
			{
				if (shopProducts[i].productType == ProductType.Subscription || shopProducts[i].productType == ProductType.NonConsumable)
				{
					shopProducts[i].active = true;
				}
				if (OnCompleteMethod != null)
				{
					OnCompleteMethod.Invoke(IAPOperationStatus.Success, "Purchase Successful", shopProducts[i]);
				}
			}
			else if (OnCompleteMethod != null)
			{
				OnCompleteMethod.Invoke(IAPOperationStatus.Fail, "Invalid Receipt " + ((Exception)(object)exception).Message + ((Exception)(object)exception).Data, (StoreProduct)null);
			}
			break;
		}
		return (PurchaseProcessingResult)0;
	}

	private bool ReceiptIsValid(string productName, string receipt, out IAPSecurityException exception)
	{
		exception = null;
		return true;
	}
}
