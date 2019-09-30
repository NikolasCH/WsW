using UnityEngine;
using System.Collections;

public class LoadingScene : MonoBehaviour {



	private AsyncOperation async;
//	private UILabel label;
	private bool nextLoading = false;
	private int scene = 0;

	void Start () 
	{
	//	label = (UILabel)gameObject.GetComponent("UILabel");	
		
	}
	
	void next () 
	{
		scene = 1;
		nextLoading = true;
		StartCoroutine("_Start");
	}
	
	void menu () 
	{
		scene = 0;
		
		nextLoading = true;
		StartCoroutine("_Start");
	}

	IEnumerator _Start() {
		async = Application.LoadLevelAsync(scene);	
		yield return async;		
	}
	
	void Update () 
	{
		//if (nextLoading) label.text = "Loading..."+(Mathf.Floor(async.progress*100)).ToString();
	}
}

