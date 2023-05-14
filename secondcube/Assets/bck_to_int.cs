using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bck_to_int : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    public void sceneLd(){
		SceneManager.LoadScene("for_intestine");
	}
	 public void sceneLd1(){
		SceneManager.LoadScene("for_spine");
	}
	public void sceneLd2(){
		SceneManager.LoadScene("for_skull");
	}
	public void sceneLd3(){
		SceneManager.LoadScene("menu");
	}

}
