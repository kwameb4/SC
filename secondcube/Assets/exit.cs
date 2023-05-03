using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour {

	
	
	// Update is called once per frame
	public void endapp () {
		Debug.Log("ended");
		Application.Quit();
	}
}
