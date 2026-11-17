using System.Collections.Generic;
using System.Linq;
using GleyEasyIAP;
using UnityEngine;

public class TestIAP : MonoBehaviour
{
	public class MyStoreProducts
	{
		public ShopProductNames name;

		public bool bought;

		public MyStoreProducts(ShopProductNames name, bool bought)
		{
			this.name = name;
			this.bought = bought;
		}
	}

	private List<MyStoreProducts> consumableProducts = new List<MyStoreProducts>();

	private List<MyStoreProducts> nonCOnsumableProducts = new List<MyStoreProducts>();

	private List<MyStoreProducts> subscriptions = new List<MyStoreProducts>();

	private Vector2 scrollViewVector = Vector2.zero;

	private float buttonWidth;

	private float buttonHeight;

	private float padding;

	private int nr;

	private int indexNumberConsumable;

	private int indexNumberNonConsumable;

	private int indexNumberSubscription;

	private int coins;

	private bool purchaseInProgress;

	private bool initializationInProgress;

	private bool showConsumable;

	private bool showNonConsumable;

	private bool showSubscription;

	private bool showButtons = true;

	private void Start()
	{
		buttonWidth = Screen.width;
		padding = Screen.width / 6;
	}

	private void OnGUI()
	{
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		buttonHeight = Screen.height / (12 + nonCOnsumableProducts.Count + subscriptions.Count);
		GUI.skin.button.fontSize = 20;
		GUI.skin.label.fontSize = 25;
		GUI.skin.label.alignment = (TextAnchor)7;
		GUI.skin.textField.fontSize = 20;
		GUI.skin.textField.alignment = (TextAnchor)4;
		nr = 0;
		if (showButtons)
		{
			if (!IAPManager.Instance.IsInitialized())
			{
				if (!initializationInProgress && Button("Initialize"))
				{
					initializationInProgress = true;
					IAPManager.Instance.InitializeIAPManager(InitializeResult);
				}
			}
			else if (!purchaseInProgress)
			{
				Label("Consumable");
				if (consumableProducts.Count > 0)
				{
					if (Button("\\/   Tap to select a consumable product   \\/"))
					{
						if (!showConsumable)
						{
							showConsumable = true;
						}
						else
						{
							showConsumable = false;
						}
					}
					if (showConsumable)
					{
						DropDown(7, ref indexNumberConsumable, ref showConsumable, consumableProducts);
					}
					if (Button(string.Concat("BUY ", consumableProducts[indexNumberConsumable].name, " ", IAPManager.Instance.GetValue(consumableProducts[indexNumberConsumable].name), " Coins ", IAPManager.Instance.GetLocalizedPriceString(consumableProducts[indexNumberConsumable].name))))
					{
						purchaseInProgress = true;
						IAPManager.Instance.BuyProduct(consumableProducts[indexNumberConsumable].name, ProductBought);
					}
				}
				else
				{
					Label("No Consumable Products Defined");
				}
				Label("Non Consumable");
				if (nonCOnsumableProducts.Count > 0)
				{
					if (Button("\\/   Tap to select a non consumable product   \\/"))
					{
						if (!showNonConsumable)
						{
							showNonConsumable = true;
						}
						else
						{
							showNonConsumable = false;
						}
					}
					if (showNonConsumable)
					{
						DropDown(6, ref indexNumberNonConsumable, ref showNonConsumable, nonCOnsumableProducts);
					}
					if (Button(string.Concat("BUY ", nonCOnsumableProducts[indexNumberNonConsumable].name, " ", IAPManager.Instance.GetLocalizedPriceString(nonCOnsumableProducts[indexNumberNonConsumable].name))))
					{
						purchaseInProgress = true;
						IAPManager.Instance.BuyProduct(nonCOnsumableProducts[indexNumberNonConsumable].name, ProductBought);
					}
				}
				else
				{
					Label("No Non Consumable Products Defined");
				}
				Label("Subscription");
				if (subscriptions.Count > 0)
				{
					if (Button("\\/   Tap to select a subscription   \\/"))
					{
						if (!showSubscription)
						{
							showSubscription = true;
						}
						else
						{
							showSubscription = false;
						}
					}
					if (showSubscription)
					{
						DropDown(2, ref indexNumberSubscription, ref showSubscription, subscriptions);
					}
					if (Button(string.Concat("BUY ", subscriptions[indexNumberSubscription].name, " ", IAPManager.Instance.GetLocalizedPriceString(subscriptions[indexNumberSubscription].name))))
					{
						purchaseInProgress = true;
						IAPManager.Instance.BuyProduct(subscriptions[indexNumberSubscription].name, ProductBought);
					}
				}
				else
				{
					Label("No Subscription Defined");
				}
				if (Button("Restore Purchases"))
				{
					IAPManager.Instance.RestorePurchases(ProductBought);
				}
				GUI.skin.label.alignment = (TextAnchor)3;
				Label("Coins: " + coins);
				for (int i = 0; i < nonCOnsumableProducts.Count; i++)
				{
					Label(string.Concat(nonCOnsumableProducts[i].name, " was bought ", nonCOnsumableProducts[i].bought));
				}
				for (int j = 0; j < subscriptions.Count; j++)
				{
					Label(string.Concat(subscriptions[j].name, " was bought ", subscriptions[j].bought));
				}
			}
		}
		if (GUI.Button(new Rect(0f, (float)Screen.height - buttonHeight, (float)(Screen.width / 3), buttonHeight), "Hide/Show Buttons"))
		{
			showButtons = !showButtons;
		}
	}

	private void ProductBought(IAPOperationStatus status, string message, StoreProduct product)
	{
		purchaseInProgress = false;
		if (status == IAPOperationStatus.Success)
		{
			if (IAPManager.Instance.debug)
			{
				Debug.Log((object)("Buy product completed: " + product.localizedTitle + " receive value: " + product.value));
				ScreenWriter.Write("Buy product completed: " + product.localizedTitle + " receive value: " + product.value);
			}
			if (product.productType == ProductType.Consumable)
			{
				coins += product.value;
			}
			_ = product.productName == "UnlockLevel1";
			_ = product.productName == "UnlockLevel2";
			_ = product.productName == "Subscription";
			if (product.productType == ProductType.NonConsumable)
			{
				nonCOnsumableProducts.First((MyStoreProducts cond) => cond.name.ToString() == product.productName).bought = true;
			}
			if (product.productType == ProductType.Subscription)
			{
				subscriptions.First((MyStoreProducts cond) => cond.name.ToString() == product.productName).bought = true;
			}
		}
		else if (IAPManager.Instance.debug)
		{
			Debug.Log((object)("Buy product failed: " + message));
			ScreenWriter.Write("Buy product failed: " + message);
		}
	}

	private void InitializeResult(IAPOperationStatus status, string message, List<StoreProduct> shopProducts)
	{
		initializationInProgress = false;
		consumableProducts = new List<MyStoreProducts>();
		nonCOnsumableProducts = new List<MyStoreProducts>();
		subscriptions = new List<MyStoreProducts>();
		if (status == IAPOperationStatus.Success)
		{
			for (int i = 0; i < shopProducts.Count; i++)
			{
				if (shopProducts[i].productName == "UnlockLevel1")
				{
					_ = shopProducts[i].active;
				}
				if (shopProducts[i].productName == "UnlockLevel2")
				{
					_ = shopProducts[i].active;
				}
				if (shopProducts[i].productName == "Subscription")
				{
					_ = shopProducts[i].active;
				}
				switch (shopProducts[i].productType)
				{
				case ProductType.Consumable:
					consumableProducts.Add(new MyStoreProducts(IAPManager.Instance.ConvertNameToShopProduct(shopProducts[i].productName), shopProducts[i].active));
					break;
				case ProductType.NonConsumable:
					nonCOnsumableProducts.Add(new MyStoreProducts(IAPManager.Instance.ConvertNameToShopProduct(shopProducts[i].productName), shopProducts[i].active));
					break;
				case ProductType.Subscription:
					subscriptions.Add(new MyStoreProducts(IAPManager.Instance.ConvertNameToShopProduct(shopProducts[i].productName), shopProducts[i].active));
					break;
				}
			}
		}
		if (IAPManager.Instance.debug)
		{
			Debug.Log((object)string.Concat("Init status: ", status, " message ", message));
			ScreenWriter.Write(string.Concat("Init status: ", status, " message ", message));
		}
	}

	private bool Button(string label)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		nr++;
		return GUI.Button(new Rect(0f, (float)(nr - 1) * buttonHeight, buttonWidth, buttonHeight), label);
	}

	private void Label(string label)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		GUI.Label(new Rect(0f, (float)nr * buttonHeight, buttonWidth, buttonHeight), label);
		nr++;
	}

	private void DropDown(int maxButtons, ref int indexNumber, ref bool showDropDown, List<MyStoreProducts> coll)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		Rect val = new Rect(0f, 0f * buttonHeight, buttonWidth, (float)maxButtons * buttonHeight);
		scrollViewVector = GUI.BeginScrollView(new Rect(val.x, val.y + (float)nr * buttonHeight, val.width, val.height), scrollViewVector, new Rect(0f, 0f, val.width - 100f, Mathf.Max(val.height, (float)coll.Count * buttonHeight)));
		float num = Mathf.Min(val.height, (float)coll.Count * buttonHeight);
		for (int i = 0; i < coll.Count; i++)
		{
			if (GUI.Button(new Rect(padding, (float)i * buttonHeight, buttonWidth - 2f * padding, buttonHeight), string.Concat(coll[i].name, " ", IAPManager.Instance.GetLocalizedPriceString(coll[i].name))))
			{
				showDropDown = false;
				indexNumber = i;
			}
			if ((float)i < num / buttonHeight)
			{
				nr++;
			}
		}
		GUI.EndScrollView();
	}

	public TestIAP()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
	}
}
