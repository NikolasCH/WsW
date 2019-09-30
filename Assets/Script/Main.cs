using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	
	public static int Score = 0;
	public static int block = 120;
	public static int lvl = 1;	
	public static int Coin = 500;
	public static bool play = false;
	public static int ShowTime = 0;
	public static int letter=0;
	public static string[] letters;
	public static string txt="w";
	public static string word = "угадай";
	public static string _word = "";
	public static int next = 0;
	public static int [] p =  new[]{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};
	public static GameObject bg;
	public static bool game =true;
	public static UILabel _txt;
	public static UILabel _check;

	public static UILabel _w_o;
	public static UILabel _ws_o;
	public static UILabel _l_o;
	public static bool cam = false;
	public static bool b1=false;	
	public static bool b2=false;
	public static bool b3=false;
	public static int stars=0;
	public static UISprite s_stars;

	
	public static int w_o=0;
	public static int ws_o=0;
	public static int l_o=0;

	public static bool panel_buy = false;
		

	
	public static Hashtable w = new Hashtable();  
	public static Hashtable ws = new Hashtable();  
	
	public static void check_next () {
		int n=-1;
		for(int j=0; j<p.Length; j++)
		{	
			for(int i=0; i<p.Length; i++)
			{
				if(p[i]>n && p[i]-1==n)
					n=p[i];

				next=n+1;

			}
		}
		check_word();
	}

	public static void check_stars() {
		stars =PlayerPrefs.GetInt("Star");
	}
	
	public static void check_word () {
		int l=0;
		string t ="";

		for(int i=0; i<letters.Length; i++)
		{
			 t = t+(string)w[i];
		}


		string g_word = "";

		if(PlayerPrefs.HasKey("lvl_"+lvl.ToString()))
			g_word = PlayerPrefs.GetString("lvl_"+lvl.ToString());


		string[] col_word = g_word.Split(","[0]);

		int c_w = 0;
		if(PlayerPrefs.HasKey("lvl_"+lvl.ToString()))c_w = col_word.Length;

		_check.text = c_w.ToString()+"/"+letters.Length.ToString();

	
		ws.Clear();


		_txt.text = "[000000]";


		for(int s=0; s<col_word.Length; s++)
		{
			bool _color = false;
			if(t.Length>0 && c_w>0 && t.Length<=col_word[s].Length){

				int p = 0;
				for(int a=0; a<t.Length; a++)
				{

					if(t[a]==col_word[s][a])p++;

				}
				if(p==t.Length)_color =true;

			}

			ws[col_word[s]] = 1;
			if(_color)
				_txt.text +=" [ff6633][b]"+col_word[s]+"[/b][-]";
			else
				_txt.text +=" "+col_word[s];
		}



		int k = 0;
		if(PlayerPrefs.HasKey("o_"+lvl.ToString()))k = PlayerPrefs.GetInt("o_"+lvl.ToString());


		for(int j=0; j<letters.Length; j++)
		{
			if(ws[t]==null && t==letters[j].ToString().ToUpper() && game){
				ws[t] = 1;
				l+=1;
				_txt.text +=" "+t;

				if(g_word=="")
					PlayerPrefs.SetString("lvl_"+lvl.ToString(), t);
				else
					PlayerPrefs.SetString("lvl_"+lvl.ToString(), g_word+","+t);

				CoinAdd(1);
				//CoinAdd(t.Length-k);

				c_w++;
				_check.text = c_w.ToString()+"/"+letters.Length.ToString();
				int _star = 0;
				if(c_w*100/letters.Length>=25)_star = 1;
				if(c_w*100/letters.Length>=50)_star = 2;
				if(c_w*100/letters.Length>=75)_star = 3;
				if(_star>PlayerPrefs.GetInt("s_"+lvl.ToString())){
					PlayerPrefs.SetInt("s_"+lvl.ToString(), _star);
					stars=PlayerPrefs.GetInt("Star");
					stars++;
					PlayerPrefs.SetInt("Star", stars);
					ScoreUp();
				}

				GameObject w = GameObject.Find("word");
				w.SendMessage("goodWord");	
			}
		}



	
		if(k>0 && ws[t]==null){

			_txt.text+="  \n\n[dddddd]";


			for(int f=0; f<letters.Length; f++)
			{
				if(ws[letters[f].ToString().ToUpper()]==null){
					for(int d=0; d<letters[f].Length; d++)
					{
						if(d<=k-1)
							_txt.text +=letters[f][d];
						else
							_txt.text +="_";
					}
					_txt.text +=" ";
				}
			}

			_txt.text+="[-]";
		}

		PlayerPrefs.SetFloat("w_"+lvl.ToString(), letters.Length);
		PlayerPrefs.SetFloat("c_"+lvl.ToString(), c_w);

		s_stars.fillAmount =(float)c_w/letters.Length*1.3f;

		Cost_Letters();
		Cost_Word();
	}
	
	public static void Play(){
		_w_o = (UILabel)GameObject.Find("_w_o").GetComponent("UILabel");
		_ws_o = (UILabel)GameObject.Find("_ws_o").GetComponent("UILabel");
		_l_o = (UILabel)GameObject.Find("_l_o").GetComponent("UILabel");

		_txt = (UILabel)GameObject.Find("txt").GetComponent("UILabel");
		_check = (UILabel)GameObject.Find("check").GetComponent("UILabel");
		s_stars = (UISprite)GameObject.Find("Star1").GetComponent("UISprite");

		//PlayerPrefs.DeleteAll();
		//PlayerPrefs.SetInt("lvl", 1);
		//PlayerPrefs.SetInt("Coin", 5000);
		onGameCenter();
		Coin = PlayerPrefs.GetInt("Coin");

		stars= PlayerPrefs.GetInt("Star");
		lvl = PlayerPrefs.GetInt("lvl");

		p = new[]{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};
		w.Clear();
		ws.Clear();
		next=0;
		word = baza.words[lvl,0];	
		letters =  baza.words[lvl,2].Split(","[0]);

		bg  = GameObject.Find("bg");

		NGUITools.SetActive(bg, false);
		stars =PlayerPrefs.GetInt("Star");
		ScoreUp();
		CoinUp();

		letter = word.Length;

		LevelUp();

		check_word ();

	}


	public static void Cost_Word () {	
		w_o = 0;
		ws_o = 0;
		for(int f=0; f<letters.Length; f++)
		{
			string t =letters[f].ToString().ToUpper();
			if(ws[t]==null){
				if(w_o==0)w_o=letters[f].Length*2;
				ws_o+=letters[f].Length*2;
			}
		}
		
		_l_o.text= w_o.ToString();
		_ws_o.text= ws_o.ToString();
	}

	public static void Open_Word () {	
		if(Coin>=w_o){
			Coin-=w_o;
			PlayerPrefs.SetInt("Coin", Coin);

			UILabel Txt = (UILabel)GameObject.Find("coin_lbl").GetComponent("UILabel");		
			Txt.text = Coin.ToString();

			string g_word = "";
			
			if(PlayerPrefs.HasKey("lvl_"+lvl.ToString()))
				g_word = PlayerPrefs.GetString("lvl_"+lvl.ToString());
			
			
			string[] col_word = g_word.Split(","[0]);
			int c_w = 0;
			if(PlayerPrefs.HasKey("lvl_"+lvl.ToString()))c_w = col_word.Length;

			for(int f=0; f<letters.Length; f++)
			{
				string t =letters[f].ToString().ToUpper();
				if(ws[t]==null){
					_txt.text +=" "+t;
					ws[t] =1;

					if(g_word=="")
						PlayerPrefs.SetString("lvl_"+lvl.ToString(), t);
					else
						PlayerPrefs.SetString("lvl_"+lvl.ToString(), g_word+","+t);

					int _star = 0;
					c_w++;

					if(c_w*100/letters.Length>=25)_star = 1;
					if(c_w*100/letters.Length>=50)_star = 2;
					if(c_w*100/letters.Length>=75)_star = 3;

					if(_star>PlayerPrefs.GetInt("s_"+lvl.ToString())){
						PlayerPrefs.SetInt("s_"+lvl.ToString(), _star);
						stars=PlayerPrefs.GetInt("Star");
						stars++;
						PlayerPrefs.SetInt("Star", stars);
						ScoreUp();
					}
					break;
				}
			}
			check_word();
		}else{
			Buttons.ups();
		}
	}

	public static void Open_Words () {	
		if(Coin>=ws_o){
			Coin-=ws_o;
			PlayerPrefs.SetInt("Coin", Coin);
			
			UILabel Txt = (UILabel)GameObject.Find("coin_lbl").GetComponent("UILabel");		
			Txt.text = Coin.ToString();
			
			string g_word = "";
			
			if(PlayerPrefs.HasKey("lvl_"+lvl.ToString()))
				g_word = PlayerPrefs.GetString("lvl_"+lvl.ToString());
			
			
			string[] col_word = g_word.Split(","[0]);
			int c_w = 0;
			if(PlayerPrefs.HasKey("lvl_"+lvl.ToString()))c_w = col_word.Length;
			
			for(int f=0; f<letters.Length; f++)
			{
				string t =letters[f].ToString().ToUpper();
				if(ws[t]==null){
					_txt.text +=" "+t;
					ws[t] =1;
					
					if(g_word=="")
						g_word=t;
					else
						g_word+=","+t;
					
					PlayerPrefs.SetString("lvl_"+lvl.ToString(), g_word);
					
					int _star = 0;
					c_w++;
					
					if(c_w*100/letters.Length>=25)_star = 1;
					if(c_w*100/letters.Length>=50)_star = 2;
					if(c_w*100/letters.Length>=75)_star = 3;
					
					if(_star>PlayerPrefs.GetInt("s_"+lvl.ToString())){
						PlayerPrefs.SetInt("s_"+lvl.ToString(), _star);
						stars=PlayerPrefs.GetInt("Star");
						stars++;
						PlayerPrefs.SetInt("Star", stars);
						ScoreUp();
					}
				}
			}
			check_word();
		}else{
			Buttons.ups();
		}
	}



	public static void Cost_Letters () {	
		int k = 0;
		l_o = 0;
		if(PlayerPrefs.HasKey("o_"+lvl.ToString()))k = PlayerPrefs.GetInt("o_"+lvl.ToString());
		for(int f=0; f<letters.Length; f++)
		{
			string t =letters[f].ToString().ToUpper();
			if(ws[t]==null){
				if(k<letters[f].Length)
					l_o+=3;
			}
		}
		_w_o.text= l_o.ToString();
	}

	public static void Open_Letters () {	
		if(Coin>=l_o){
			Coin-=l_o;
			PlayerPrefs.SetInt("Coin", Coin);
			UILabel Txt = (UILabel)GameObject.Find("coin_lbl").GetComponent("UILabel");		
			Txt.text = Coin.ToString();

			int k = 0;
			if(PlayerPrefs.HasKey("o_"+lvl.ToString()))k = PlayerPrefs.GetInt("o_"+lvl.ToString());

			PlayerPrefs.SetInt("o_"+lvl.ToString(),k+1);

			check_word();
		}else{
			Buttons.ups();
		}
	}	

	public static void ScoreUp ( ) {
		UILabel Txt = (UILabel)GameObject.Find("score_lbl").GetComponent("UILabel");	
		Txt.text = PlayerPrefs.GetInt("Star").ToString();			
	}	
	
	public static void CoinAdd (int AddScore) {	
			Coins co = (Coins)GameObject.Find("coin_add").GetComponent("Coins");
			co.coins.text = "+"+AddScore.ToString(); 
			co.Add();
			Coin+=AddScore;
			PlayerPrefs.SetInt("Coin", Coin);
			CoinUp();
	}	
	
	public static void CoinUp ( ) {	
			int _coin  = PlayerPrefs.GetInt("Coin");
			UILabel Txt = (UILabel)GameObject.Find("coin_lbl").GetComponent("UILabel");		
			Txt.text = _coin.ToString();			
	}	

	public static void LevelAdd ( ) {
			lvl = PlayerPrefs.GetInt("lvl");
			lvl+=1;
			PlayerPrefs.SetInt("lvl", lvl);
	}	
	
	public static void LevelUp ( ) {	
			UILabel Txt = (UILabel)GameObject.Find("lvl_lbl").GetComponent("UILabel");		
			Txt.text = lvl.ToString();
	}

	public static void good ( ) {		
		GameObject w = GameObject.Find("word");
		w.SendMessage("good_wait");		
	}
	
	public static void buy ( ) {		
		PlayerPrefs.SetInt("Ad", 1);	
		GameObject w = GameObject.Find("word");;
		w.SendMessage("onCoin");
	}
	
	public static void bad ( ) {		
		GameObject w = GameObject.Find("word");;
		w.SendMessage("bad_wait");
	}
	

	public static void onBuy (string product)
	{
		Debug.Log("InApp " + product);
		GameObject InApp = GameObject.Find("InApp");
		InAppAI ch = (InAppAI)InApp.GetComponent("InAppAI");
		ch.onInApp(product);
	}

	public static void showMoreApps ()
	{
		Application.OpenURL("https://play.google.com/store/apps/developer?id=Sayrex");
	}
	public static void onLeaderBoard ()
	{
		Debug.Log("onLeaderBoard");
		GameObject gameCenter = GameObject.Find("GameCenter");
		GameCenterAI gm = (GameCenterAI)gameCenter.GetComponent("GameCenterAI");
		gm.onShowLeaderBoard();
	}

	public static void postScoreToLeaderBoard(int id,int _score)
	{
		GameObject gameCenter = GameObject.Find("GameCenter");
		GameCenterAI gm = (GameCenterAI)gameCenter.GetComponent("GameCenterAI");
		gm.onSubmitScore(_score);
	}

	public static void onShowInterstitial ()
	{
		Debug.Log ("onShowInterstitial");
		if (PlayerPrefs.GetInt ("Ad") != 1)
			GameObject.Find ("AdMob").GetComponent<AdMobAI> ().ShowInterstitial ();
	}


	public static void onShow(){
		if(PlayerPrefs.GetInt("Ad")!=1){
			if (ShowTime == 1 || ShowTime == 3)
			{
				onShowInterstitial ();
			}	else	{	
				if (ShowTime > 4){	ShowTime = 0;	}	else	{	ShowTime++;	}
			}	
		}
	}
	
	
	public static void install(){		
		PlayerPrefs.SetInt("Btn1",0);
		PlayerPrefs.SetInt("Btn2",0);
		PlayerPrefs.SetInt("Btn3",0);
		PlayerPrefs.SetInt("Btn4",0);
		PlayerPrefs.SetInt("Btn5",0);
		PlayerPrefs.SetInt("Btn6",0);
		PlayerPrefs.SetInt("Btn7",0);
		PlayerPrefs.SetInt("Btn8",0);
		PlayerPrefs.SetInt("Btn9",0);
		PlayerPrefs.SetInt("Btn10",0);
		PlayerPrefs.SetInt("Btn11",0);
		PlayerPrefs.SetInt("Btn12",0);
			PlayerPrefs.SetInt("l1", -1);
			PlayerPrefs.SetInt("l2", -1);
			PlayerPrefs.SetInt("l3", -1);
			PlayerPrefs.SetInt("l4", -1);
			PlayerPrefs.SetInt("l5", -1);
			PlayerPrefs.SetInt("l6", -1);
			PlayerPrefs.SetInt("l7", -1);
			PlayerPrefs.SetInt("l8", -1);
			PlayerPrefs.SetInt("l9", -1);
			PlayerPrefs.SetInt("l10", -1);
			PlayerPrefs.SetInt("l11", -1);
			PlayerPrefs.SetInt("l12", -1);
			PlayerPrefs.SetInt("l13", -1);
			PlayerPrefs.SetInt("l14", -1);
			PlayerPrefs.SetInt("o0", -1);
			PlayerPrefs.SetInt("o1", -1);
			PlayerPrefs.SetInt("o2", -1);
			PlayerPrefs.SetInt("o3", -1);
			PlayerPrefs.SetInt("o4", -1);
			PlayerPrefs.SetInt("o5", -1);
			PlayerPrefs.SetInt("o6", -1);
			PlayerPrefs.SetInt("o7", -1);
			PlayerPrefs.SetInt("o8", -1);
			PlayerPrefs.SetInt("num_lett", -1);
			PlayerPrefs.SetInt("new", 1);
			PlayerPrefs.SetInt("lvl", 1);
			PlayerPrefs.SetInt("Coin", 50);
			PlayerPrefs.SetInt("Score", 0);
			PlayerPrefs.SetInt("HIGHSCORE", 0);	
			PlayerPrefs.SetInt("open", 0);
			PlayerPrefs.SetInt("bon", 0);
			PlayerPrefs.SetInt("Ad",0);
	}
	
	public static void onGameCenter(){
		postScoreToLeaderBoard(0,stars);
	}	

}
