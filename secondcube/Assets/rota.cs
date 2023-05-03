using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rota : MonoBehaviour {
 int rotation=10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (rotation * Time.deltaTime,0,0);
	}
}
