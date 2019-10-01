using UnityEngine;
using System.Collections;

public class InAppAI : MonoBehaviour {
#if UNITY_ANDROID
	
	void Awake() {
		init();
	}


	private static bool _isInited = false;
	
	//--------------------------------------
	//  INITIALIZE
	//--------------------------------------
	
	
	//replace with your consumable item
	public const string COINS_ITEM1 = "wfw_p1";
	
	public const string COINS_ITEM2 = "wfw_p2";
	
	public const string COINS_ITEM3 = "wfw_p3";
	
	public const string COINS_ITEM4 = "wfw_p4";
	
	public const string COINS_ITEM5 = "wfw_p5";

	public const string COINS_ITEM6 = "page_1";

	public const string COINS_ITEM7 = "page_2";

	public const string COINS_ITEM8 = "page_3";

	public const string COINS_ITEM9 = "page_4";
	
	
	//replace with your non-consumable item
	public const string COINS_BOOST = "coins_bonus";
	
	
	//public const string base64EncodedPublicKey = "REPLACE_WITH_YOUR_PUBLIC_KEY";
	public const string base64EncodedPublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAqm9uQzL6ZjNdln9s0hrBP/Dm4Jwx/t1ynoZyFn7H9FeN64FAj49A/lI1k3bn2M/CPpiBE9FS2tpRGXUf3IEzJ1IsMcV0aRg3yMZkktw/USMYPx0RzzjWLnT3e4ywaGXHIL+T8Rqm0Z/M5hOhc4z4DcrSKwjATEQTq9UrNRBtilA82VntoM4RvoYIWjj3p7FQQzSCY33idfyWb6V5LW0QGR+CBaRPcp59hZNtdT/Qzd9mZ+w5HY3wZjTtt8aHhZFh2a7T4jNyDRvjpXBM8f3hAn3mS0AFrtQToijjFC3yWIcNHCQKK9ipZvmuOF8Bk0QVUhXqLjVNg0sMWJSROy0iSwIDAQAB";
	
	public void onInApp(string item){
		
		Debug.Log(item);

		if(item=="pack1")purchase(COINS_ITEM1);
		if(item=="pack2")purchase(COINS_ITEM2);
		if(item=="pack3")purchase(COINS_ITEM3);
		if(item=="pack4")purchase(COINS_ITEM4);
		if(item=="pack5")purchase(COINS_ITEM5);
		if(item=="page_1")purchase(COINS_ITEM6);
		if(item=="page_2")purchase(COINS_ITEM7);
		if(item=="page_3")purchase(COINS_ITEM8);
		if(item=="page_4")purchase(COINS_ITEM9);
	}
	
	public static void init() {
		
		
		//Filling product list
		AndroidInAppPurchaseManager.instance.addProduct(COINS_ITEM1);
		AndroidInAppPurchaseManager.instance.addProduct(COINS_ITEM2);
		AndroidInAppPurchaseManager.instance.addProduct(COINS_ITEM3);
		AndroidInAppPurchaseManager.instance.addProduct(COINS_ITEM4);
		AndroidInAppPurchaseManager.instance.addProduct(COINS_ITEM5);
		AndroidInAppPurchaseManager.instance.addProduct(COINS_ITEM6);
		AndroidInAppPurchaseManager.instance.addProduct(COINS_ITEM7);
		AndroidInAppPurchaseManager.instance.addProduct(COINS_ITEM8);
		AndroidInAppPurchaseManager.instance.addProduct(COINS_ITEM9);

		//listening for purchase and consume events
		AndroidInAppPurchaseManager.instance.addEventListener (AndroidInAppPurchaseManager.ON_PRODUCT_PURCHASED, OnProductPurchased);
		AndroidInAppPurchaseManager.instance.addEventListener (AndroidInAppPurchaseManager.ON_PRODUCT_CONSUMED,  OnProductConsumed);
		
		//initilaizing store
		AndroidInAppPurchaseManager.instance.addEventListener (AndroidInAppPurchaseManager.ON_BILLING_SETUP_FINISHED, OnBillingConnected);
		AndroidInAppPurchaseManager.instance.loadStore(base64EncodedPublicKey);
		
		
		
	}
	
	//--------------------------------------
	//  PUBLIC METHODS
	//--------------------------------------
	
	
	public static void purchase(string SKU) {
		AndroidInAppPurchaseManager.instance.purchase (SKU);
	}
	
	public static void consume(string SKU) {
		AndroidInAppPurchaseManager.instance.consume (SKU);
	}
	
	//--------------------------------------
	//  GET / SET
	//--------------------------------------
	
	public static bool isInited {
		get {
			return _isInited;
		}
	}
	
	
	//--------------------------------------
	//  EVENTS
	//--------------------------------------
	
	private static void OnProcessingPurchasedProduct(GooglePurchaseTemplate purchase) {
		//some stuff for processing product purchse. Add coins, unlock track, etc
		
		switch(purchase.SKU) {

		case COINS_ITEM1:
			consume(COINS_ITEM1);
			break;
		case COINS_ITEM2:
			consume(COINS_ITEM2);
			break;
		case COINS_ITEM3:
			consume(COINS_ITEM3);
			break;
		case COINS_ITEM4:
			consume(COINS_ITEM4);
			break;
		case COINS_ITEM5:
			consume(COINS_ITEM5);
			break;
		case COINS_ITEM6:
			consume(COINS_ITEM6);
			break;
		case COINS_ITEM7:
			consume(COINS_ITEM7);
			break;
		case COINS_ITEM8:
			consume(COINS_ITEM8);
			break;
		case COINS_ITEM9:
			consume(COINS_ITEM9);
			break;
		}
	}
	
	private static void OnProcessingConsumeProduct(GooglePurchaseTemplate purchase) {
		switch(purchase.SKU) {
		case COINS_ITEM1:
			Main.CoinAdd(1000);
			Main.buy();
			break;
		case COINS_ITEM2:
			Main.CoinAdd(2200);
			Main.buy();
			break;
		case COINS_ITEM3:
			Main.CoinAdd(3600);
			Main.buy();
			break;
		case COINS_ITEM4:
			Main.CoinAdd(5200);
			Main.buy();
			break;
		case COINS_ITEM5:
			Main.CoinAdd(7000);
			Main.buy();
			break;
		case COINS_ITEM6:
			PlayerPrefs.SetInt(COINS_ITEM6, 1);
			Application.LoadLevelAsync(1);
			break;
		case COINS_ITEM7:
			PlayerPrefs.SetInt(COINS_ITEM7, 1);
			Application.LoadLevelAsync(1);
			break;
		case COINS_ITEM8:
			PlayerPrefs.SetInt(COINS_ITEM8, 1);
			Application.LoadLevelAsync(1);
			break;
		case COINS_ITEM9:
			PlayerPrefs.SetInt(COINS_ITEM9, 1);
			Application.LoadLevelAsync(1);
			break;
		}
	}

	private static void OnProductPurchased(CEvent e) {
		BillingResult result = e.data as BillingResult;
		
		
		if(result.isSuccess) {
			OnProcessingPurchasedProduct (result.purchase);
		} else {
			//AndroidMessage.Create("Product Purchase Failed", result.response.ToString() + " " + result.message);
		}
		
		Debug.Log ("Purchased Responce: " + result.response.ToString() + " " + result.message);
	}
	
	
	private static void OnProductConsumed(CEvent e) {
		BillingResult result = e.data as BillingResult;
		
		if(result.isSuccess) {
			OnProcessingConsumeProduct (result.purchase);
		} else {
			//AndroidMessage.Create("Product Cousume Failed", result.response.ToString() + " " + result.message);
		}
		
		Debug.Log ("Cousume Responce: " + result.response.ToString() + " " + result.message);
	}
	
	
	private static void OnBillingConnected(CEvent e) {
		BillingResult result = e.data as BillingResult;
		AndroidInAppPurchaseManager.instance.removeEventListener (AndroidInAppPurchaseManager.ON_BILLING_SETUP_FINISHED, OnBillingConnected);
		
		
		if(result.isSuccess) {
			//Store connection is Successful. Next we loading product and customer purchasing details
			AndroidInAppPurchaseManager.instance.addEventListener (AndroidInAppPurchaseManager.ON_RETRIEVE_PRODUC_FINISHED, OnRetriveProductsFinised);
			AndroidInAppPurchaseManager.instance.retrieveProducDetails();
			
		} 
		
		//AndroidMessage.Create("Connection Responce", result.response.ToString() + " " + result.message);
		Debug.Log ("Connection Responce: " + result.response.ToString() + " " + result.message);
	}
	
	
	
	
	private static void OnRetriveProductsFinised(CEvent e) {
		BillingResult result = e.data as BillingResult;
		AndroidInAppPurchaseManager.instance.removeEventListener (AndroidInAppPurchaseManager.ON_RETRIEVE_PRODUC_FINISHED, OnRetriveProductsFinised);
		
		if(result.isSuccess) {
			
			UpdateStoreData();
			_isInited = true;
			
			
		} else {
			//AndroidMessage.Create("Connection Responce", result.response.ToString() + " " + result.message);
		}
		
	}
	
	
	
	private static void UpdateStoreData() {
		//chisking if we already own some consuamble product but forget to consume those
		if(AndroidInAppPurchaseManager.instance.inventory.IsProductPurchased(COINS_ITEM1)) {
			consume(COINS_ITEM1);
		}
		if(AndroidInAppPurchaseManager.instance.inventory.IsProductPurchased(COINS_ITEM2)) {
			consume(COINS_ITEM2);
		}
		if(AndroidInAppPurchaseManager.instance.inventory.IsProductPurchased(COINS_ITEM3)) {
			consume(COINS_ITEM3);
		}
		if(AndroidInAppPurchaseManager.instance.inventory.IsProductPurchased(COINS_ITEM4)) {
			consume(COINS_ITEM4);
		}
		if(AndroidInAppPurchaseManager.instance.inventory.IsProductPurchased(COINS_ITEM5)) {
			consume(COINS_ITEM5);
		}

		if(AndroidInAppPurchaseManager.instance.inventory.IsProductPurchased(COINS_ITEM6)) {
			consume(COINS_ITEM6);
		}
		if(AndroidInAppPurchaseManager.instance.inventory.IsProductPurchased(COINS_ITEM7)) {
			consume(COINS_ITEM7);
		}
		if(AndroidInAppPurchaseManager.instance.inventory.IsProductPurchased(COINS_ITEM8)) {
			consume(COINS_ITEM8);
		}
		if(AndroidInAppPurchaseManager.instance.inventory.IsProductPurchased(COINS_ITEM9)) {
			consume(COINS_ITEM9);
		}

	}
#endif
}