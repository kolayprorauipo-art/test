using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class NoMoreAds : MonoBehaviour
{
	public GameObject noAdsButton;

	private const string adAvailableFileName = "ADSon";

	public void Start()
	{
		IAPManager.Instance.InitializeIAPManager(InitComplete);
	}

	private void InitComplete(IAPOperationStatus status, string errorMessage, List<StoreProduct> allStoreProducts)
	{
		if (status == IAPOperationStatus.Success)
		{
			for (int i = 0; i < allStoreProducts.Count; i++)
			{
				if (allStoreProducts[i].productName == ShopProductNames.NoAds.ToString() && allStoreProducts[i].active)
				{
					SetAdAvailable(state: true);
				}
			}
			RefreshMenu();
		}
		else
		{
			Debug.Log((object)("Initialization failed" + errorMessage));
		}
	}

	private void OnEnable()
	{
		RefreshMenu();
	}

	public static void SetAdAvailable(bool state)
	{
		if (!state)
		{
			PlayerPrefs.SetInt("ADSon", 0);
		}
		else
		{
			PlayerPrefs.SetInt("ADSon", 1);
		}
	}

	public static bool IsAdAvailable()
	{
		if (!PlayerPrefs.HasKey("ADSon") || PlayerPrefs.GetInt("ADSon") == 0)
		{
			return false;
		}
		return true;
	}

	private void RefreshMenu()
	{
		if (!IsAdAvailable())
		{
			noAdsButton.SetActive(true);
		}
		else
		{
			noAdsButton.SetActive(false);
		}
	}

	public void RemoveAds()
	{
		IAPManager.Instance.BuyProduct(ShopProductNames.NoAds, productBought);
	}

	private void productBought(IAPOperationStatus status, string errorMessage, StoreProduct boughtProduct)
	{
		if (status == IAPOperationStatus.Success && boughtProduct.productName == ShopProductNames.NoAds.ToString())
		{
			SetAdAvailable(state: true);
			noAdsButton.SetActive(false);
		}
	}
}
