using UnityEngine;
using System.Collections;

public class ReSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(Screen.width==1024 || Screen.width==2048)gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 1);
		//if(Screen.width==960)gameObject.transform.localScale = new Vector3(0.9f, 0.9f, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
