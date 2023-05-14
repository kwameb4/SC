using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objectclicker : MonoBehaviour {
public GameObject h;
private GameObject ij;
public string ff;
//private Text UIText;
int click=0;
private AudioSource[] allAudioSources;
private List<string> objlist=new List<string>();

 TouchPhase touchPhase = TouchPhase.Ended;
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
		if(Input.touchCount == 1 && Input.GetTouch(0).phase == touchPhase ||Input.GetMouseButtonDown(0)){//for touch screen ,if doesnt work try below
		//if(Input.GetMouseButtonDown(0)){
			
			 
		RaycastHit hit;
		
		Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
		bool hitfound= Physics.Raycast(ray,out hit,100.0f);
		if(hitfound){
			click++;
			//Debug.Log("found");
			objlist.Add(hit.transform.gameObject.name);
			//array to save game object
			
			
			//hit.transform.gameObject.GetComponent<AudioSource>().Stop();
			 h=hit.transform.gameObject;
			// h.GetComponent<AudioSource>().Stop();
			 
			 ff=h.name;
			 Debug.Log(ff);
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
			//UIText=h.GetComponent<UnityEngine.UI.Text>().text;
			//Debug.Log(UIText);
			ij.GetComponent<Renderer>().material.color = Color.grey;
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
		guiStyle.wordWrap = true;
		guiStyle.fontSize = 35;
		guiStyle.normal.textColor=Color.white;
		int windowWidth = 100;
         int windowHeight = 100;
         int x = (Screen.width - windowWidth) / 2;
         int y = (Screen.height - windowWidth) / 2;
		//guiStyle.fontColor=Color.white;
		   GUI.Label(new Rect(Screen.width - 400,Screen.height-400,400,180),ff,guiStyle);
		   //GUI.Box(new Rect(Screen.width/2-60, 20 , 400, 40),ff,guiStyle );
    }}