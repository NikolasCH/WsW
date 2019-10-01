using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {

	public GameObject _obj;

	public UISprite p0;
	public UISprite p1;
	public UISprite p2;
	public UISprite p3;
	public UISprite p4;



	// Update is called once per frame
	void Start () {
		
		Main.onShow();

		Main.ScoreUp();

		Main.CoinUp();

		if(Screen.width==1024 || Screen.width==2048)gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 1);
		if(Screen.width==960)gameObject.transform.localScale = new Vector3(0.9f, 0.9f, 1);

		int page = 0;
		if(PlayerPrefs.HasKey("page"))page = PlayerPrefs.GetInt("page");


		if(page==0)p0.spriteName = "tochka2";
		if(page==1)p1.spriteName = "tochka2";
		if(page==2)p2.spriteName = "tochka2";
		if(page==3)p3.spriteName = "tochka2";
		if(page==4)p4.spriteName = "tochka2";


		int l = 0+(40*page);
		int o = 1;
		for (int i = 0; i<5; i++){
			for (int j = 0; j<8; j++){
				l++;
				//GameObject lvl = (GameObject)Instantiate(_obj);
				GameObject lvl = GameObject.Find("l_"+o.ToString());

				//lvl.transform.parent = gameObject.transform;
				//lvl.name = "l_"+l.ToString();

				//lvl.transform.localScale = new Vector3(0.7f, 0.7f, 0);
				//lvl.transform.localPosition = new Vector3(-525 +150*j, 310-150*i, 0);
				Level _lvl = (Level)lvl.GetComponent("Level");

				_lvl.label.text = l.ToString();
				_lvl._Level = l;
				
				_lvl.star1.fillAmount = 0;
				float w = 0;
				float c = 0;
				if(PlayerPrefs.HasKey("w_"+l.ToString()))w =PlayerPrefs.GetFloat("w_"+l.ToString());
				if(PlayerPrefs.HasKey("c_"+l.ToString()))c =PlayerPrefs.GetFloat("c_"+l.ToString());

				if(c>0 && w>0)_lvl.star1.fillAmount=c/w*1.3f;
				o ++;
			}
		}
	}
}
