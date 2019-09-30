using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Awake () {

		if(PlayerPrefs.GetInt("new")!=1){
			Main.install();
		}
		Main.onShow();
		Main.stars =PlayerPrefs.GetInt("Star");
	}


}
