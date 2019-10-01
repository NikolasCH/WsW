using UnityEngine;
using System.Collections;

public class page : MonoBehaviour {

	public UILabel lbl;
	public UILabel p_lbl;
	public GameObject left;
	public GameObject right;
	// Use this for initialization
	void Start () {
		int page = 0;

		if(PlayerPrefs.HasKey("page"))page = PlayerPrefs.GetInt("page");
		lbl.text =(page*Main.block+page*10).ToString();
		p_lbl.text = "открыть за "+(100*page-1).ToString()+" руб.";
		if(Main.stars>=page*Main.block+page*10 ||  PlayerPrefs.GetInt("page_"+page.ToString())==1)gameObject.SetActive(false);

		if(page==0)left.SetActive(false);
		if(page==4)right.SetActive(false);

	}

}
