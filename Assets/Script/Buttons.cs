using UnityEngine;
using System.Collections;

public class Buttons : Main {

	private AsyncOperation async;
	private bool Loading = false;
	private int scene = 0;

	private GameObject Panel_Buy;

	//	private UILabel label;
	
	void Start () 
	{
		Main.panel_buy = false;	
		Panel_Buy = GameObject.Find("Panel_Buy");
		//	label = (UILabel)gameObject.GetComponent("UILabel");		
	}

	void Update () 
	{
		//if (nextLoading) label.text = "Loading..."+(Mathf.Floor(async.progress*100)).ToString();
	}

	void OnPress (bool isDown)
	{
		if (isDown == false)
		{
			if(gameObject.name=="More")
				Main.showMoreApps();

			if(gameObject.name=="Map"){
				LoadScene(1);
			}
			if(gameObject.name=="Start"){
				PlayerPrefs.SetInt("page", 0);
				LoadScene(1);
			}
			
			if(gameObject.name=="Level" || gameObject.name=="Next")
				LoadScene(2);
			
			if(gameObject.name=="Panel_buy")
				panel_buy_up();

			if(gameObject.name=="Panel_buys")
				panel_buy_ups();

			if(gameObject.name=="Back")
				LoadScene(0);	

			if(gameObject.name=="o_letters")
				Main.Open_Letters();

			if(gameObject.name=="o_words")
				Main.Open_Word();

			if(gameObject.name=="o_wordss")
				Main.Open_Words();


			if(gameObject.name=="Backspace" && Main.next>0)
			{
				GameObject w = GameObject.Find("letter"+(Main.next-1).ToString());;
				w.SendMessage("addLetters");
				Main.check_next();
			}

			if(gameObject.name=="Page_right")
			{
				int page = 0;
				if(PlayerPrefs.HasKey("page"))page = PlayerPrefs.GetInt("page");
				page--;
				if(page<0)page=0;
				PlayerPrefs.SetInt("page", page);
				LoadScene(1);
			}

			if(gameObject.name=="pack1")Main.onBuy("pack1");
			if(gameObject.name=="pack2")Main.onBuy("pack2");
			if(gameObject.name=="pack3")Main.onBuy("pack3");
			if(gameObject.name=="pack4")Main.onBuy("pack4");
			if(gameObject.name=="pack5")Main.onBuy("pack5");	
			if(gameObject.name=="buy_page")Main.onBuy("page_"+PlayerPrefs.GetInt("page").ToString());


			if(gameObject.name=="Page_left")
			{
				int page = 0;
				if(PlayerPrefs.HasKey("page"))page = PlayerPrefs.GetInt("page");
				page++;
				if(page>4)page=4;
				PlayerPrefs.SetInt("page", page);
				LoadScene(1);
			}

			if(gameObject.name=="FaceBook")
				Application.OpenURL("https://www.facebook.com/SayrexGames/");	
			
			if(gameObject.name=="Sayrex")
				Application.OpenURL("https://www.facebook.com/SayrexGames/");


			if(gameObject.name=="GameCenter")
				Main.onLeaderBoard();	
		}
	}

	//function

	void LoadScene (int _scene) 
	{
		scene = _scene;	
		Loading = true;
		StartCoroutine("_Start");
	}

	IEnumerator _Start() {
		async = Application.LoadLevelAsync(scene);	
		yield return async;		
	}

	public void panel_buy_down(){
		if(Main.panel_buy){
			Main.panel_buy = false;		
			TweenPosition tp = Panel_Buy.AddComponent<TweenPosition>();
			tp.from = Panel_Buy.transform.localPosition;
			tp.to = new Vector3(0, 900, -1);
			tp.duration = 0.5f;
			tp.Play(true);		
		} else {
			panel_buy_up();
		}
	}
	public void panel_buy_up(){
		if(!Main.panel_buy){
			Main.panel_buy = true;	
			TweenPosition tp = Panel_Buy.AddComponent<TweenPosition>();
			tp.from = Panel_Buy.transform.localPosition;
			tp.to = new Vector3(0, 20, -1);
			tp.duration = 0.5f;
			tp.Play(true);		
		} else {
			panel_buy_down();
		}
	}
	
	public void panel_buy_ups(){
		if(!Main.panel_buy){
			Main.panel_buy = true;	
			TweenPosition tp = Panel_Buy.AddComponent<TweenPosition>();
			tp.from = Panel_Buy.transform.localPosition;
			tp.to = new Vector3(0, -120, -1);
			tp.duration = 0.5f;
			tp.Play(true);		
		} else {
			panel_buy_down();
		}
	}
	public static void ups(){
		GameObject Panel_Buys = GameObject.Find("Panel_Buy");
		if(!Main.panel_buy){
			Main.panel_buy = true;	
			TweenPosition tp = Panel_Buys.AddComponent<TweenPosition>();
			tp.from = Panel_Buys.transform.localPosition;
			tp.to = new Vector3(0, -120, -1);
			tp.duration = 0.5f;
			tp.Play(true);		
		} else {
			Main.panel_buy = false;		
			TweenPosition tp = Panel_Buys.AddComponent<TweenPosition>();
			tp.from = Panel_Buys.transform.localPosition;
			tp.to = new Vector3(0, 900, -1);
			tp.duration = 0.5f;
			tp.Play(true);		
		}
	}
}
