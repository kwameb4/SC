using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour {
public AudioSource m_audio;
	// Use this for initialization
	void Start () {
		m_audio=GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	public void StopAudio(){
		m_audio.Stop();
	}
}
