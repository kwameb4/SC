using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectclicker : MonoBehaviour {
public GameObject h;
public GameObject ij;
public string ff;
int click=0;
private AudioSource[] allAudioSources;
private List<string> objlist=new List<string>();
private GameObject Slot1;
private int SelectedSlot = 1;


	// Use this for initialization
	void Start () {
		 objlist.Add("hi");
		}
	

	// Update is called once per frame
	void Awake(){
		
	}
	void Update () {
	//	StopAllAudio();
		//StartAllAudio();
		
	//	i.GetComponent<AudioSource>().Stop();
		//if (Input.touchCount == 1){//for touch screen ,if doesnt work try below
		if(Input.GetMouseButtonDown(0)){
			
			 
		RaycastHit hit;
		
		Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
		bool hitfound= Physics.Raycast(ray,out hit,100.0f);
		if(hitfound){
			click++;
			objlist.Add(hit.transform.gameObject.name);
			//array to save game object
			
			
			//hit.transform.gameObject.GetComponent<AudioSource>().Stop();
			 h=hit.transform.gameObject;
			// h.GetComponent<AudioSource>().Stop();
			 
			 ff=h.name;
			// h.GetComponent<AudioSource>().Play();
			//get total number of items in list -1 to get most previous
			//Debug.Log(objlist[click-1]);




			
			int n=click-1;
			string nn=objlist[n];
			/////////////////////////////////////////////////////// 
			ij= GameObject.Find(objlist[n]);
			
			//objlist[click-1].transform.gameObject.GetComponent<AudioSource>().Stop();
			//ij.transform.gameObject.GetComponent<AudioSource>().Play();
			Debug.Log(ij);
			ij.GetComponent<AudioSource>().Stop();

			//ij.GetComponent<Renderer> ().material.color = Color.blue;
			h.GetComponent<AudioSource>().Play();

			h.GetComponent<Renderer> ().material.color = Color.green;
			}
			else{
			//ij.GetComponent<Renderer> ().material.color = Color.green;
			h.GetComponent<Renderer> ().material.color = Color.grey;
			ij.GetComponent<AudioSource>().Stop();
			h.GetComponent<AudioSource>().Stop();
		}	}
		}
		private GUIStyle guiStyle = new GUIStyle(); 
	void OnGUI(){
		guiStyle.fontSize = 40;
		//guiStyle.fontColor=Color.white;
		   GUI.Label(new Rect(40, 40, 40, 40),ff,guiStyle);
    }}
	

