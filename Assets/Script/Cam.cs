using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(Main.cam){
			Destroy(gameObject);
		} else{
			Main.cam=true;
			DontDestroyOnLoad(gameObject.transform);
		}
	}
	
}
