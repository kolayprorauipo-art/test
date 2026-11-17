using System;
using UnityEngine.Purchasing;

[Serializable]
public class StoreProduct
{
	public string productName;

	public ProductType productType;

	public string idGooglePlay;

	public string idIOS;

	public int value;

	public string localizedPriceString = "-";

	public int price;

	public string isoCurrencyCode;

	internal string localizedDescription;

	internal string localizedTitle;

	public bool active;

	public StoreProduct(string productName, ProductType productType, int value, string idGooglePlay, string idIOS)
	{
		this.productName = productName;
		this.productType = productType;
		this.value = value;
		this.idGooglePlay = idGooglePlay;
		this.idIOS = idIOS;
	}

	public StoreProduct()
	{
		productName = string.Empty;
		idGooglePlay = string.Empty;
		idIOS = string.Empty;
		productType = ProductType.Consumable;
	}

	internal ProductType GetProductType()
	{
		return (ProductType)productType;
	}

	internal string GetStoreID()
	{
		return idGooglePlay;
	}
}
