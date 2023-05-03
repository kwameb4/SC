using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour {
	public GameObject obj;
 AudioSource m_audio;
	// Use this for initialization
	void Start () {
		   ;
	}
	
	// Update is called once per frame
	
	public void PlayAudio(){
		obj.GetComponent<AudioSource>().Play();
	}
}
