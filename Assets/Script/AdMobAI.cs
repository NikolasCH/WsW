using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Attach the script to the empty gameobject on your sceneS
public class AdMobAI : MonoBehaviour {
	
	
	public string BannersUnityId;
	public GADBannerSize size = GADBannerSize.SMART_BANNER;
	public TextAnchor anchor = TextAnchor.LowerCenter;

	public static bool show = false;
	public static float time =0;	
	public static bool wait = false;
	public static float wait_time =0;
		
	private static Dictionary<string, GoogleMobileAdBanner> _refisterdBanners = null;

	void Start (){
		if(PlayerPrefs.GetInt("Ad")!=1)onWait();
	}
	
	void FixedUpdate(){
		if( PlayerPrefs.GetInt("Ad")==1 && show){
			onDestroySmartBanner();
		}

		if(show && PlayerPrefs.GetInt("Ad")!=1)
		{
			time+=Time.deltaTime;
			if(time>=30){
				show = false;
				onWait();
			}
		}
		
		if(wait && PlayerPrefs.GetInt("Ad")!=1)
		{
			wait_time+=Time.deltaTime;
			
			if(wait_time>=15){
				wait=false;
				onShowSmartBanner();
			}
		}
	}
	
	public void onShowSmartBanner(){
		Debug.Log("AdMob "+BannersUnityId );
		HideBanner();
		time = 0;
		show = true;
		wait = false;
		ShowBanner();
	}
	
	public void onDestroySmartBanner(){
		show = false;
		HideBanner();
	}
	
	public void onWait(){
		HideBanner();
		wait= true;
		wait_time=0;
	}
	
	void Awake() {
		if(AndroidAdMobController.instance.IsInited) {
			if(!AndroidAdMobController.instance.BannersUunitId.Equals(BannersUnityId)) {
				AndroidAdMobController.instance.SetBannersUnitID(BannersUnityId);
			} 
		} else {
			AndroidAdMobController.instance.Init(BannersUnityId);
		}
	}
	

	void OnDestroy() {
		HideBanner();
	}

	
	public void ShowBanner() {
		GoogleMobileAdBanner banner;
		if(refisterdBanners.ContainsKey(sceneBannerId)) {
			banner = refisterdBanners[sceneBannerId];
		}  else {
			banner = AndroidAdMobController.instance.CreateAdBanner(anchor, size);
			refisterdBanners.Add(sceneBannerId, banner);
		}

		if(banner.IsLoaded && !banner.IsOnScreen) {
			banner.Refresh();
			banner.Show();
		}
	}
	
	public void HideBanner() {
		if(refisterdBanners.ContainsKey(sceneBannerId)) {
			GoogleMobileAdBanner banner = refisterdBanners[sceneBannerId];
			if(banner.IsLoaded) {
				if(banner.IsOnScreen) {
					banner.Hide();
				}
			} else {
				banner.ShowOnLoad = false;
			}
		}
	}
	
	public static Dictionary<string, GoogleMobileAdBanner> refisterdBanners {
		get {
			if(_refisterdBanners == null) {
				_refisterdBanners = new Dictionary<string, GoogleMobileAdBanner>();
			}
			
			return _refisterdBanners;
		}
	}
	
	public string sceneBannerId {
		get {
			return gameObject.name;
		}
	}

		public void ShowInterstitial ()
	{
		AndroidAdMobController.instance.StartInterstitialAd ();
	}
	
}
