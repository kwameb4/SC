using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
	public Vector3 Axis = Vector3.down;
    public float rotationSpeed=5f;
   
    private Vector3 newRotation = new Vector3(90,0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
	//transform.Rotate(90.0f, 0.0f, 0.0f, Space.World);
        //transform.Rotate(rotationSpeed * Time.deltaTime,0 ,0,Space.World);
		//transform.Rotate(0,0,Space.Self);
    }
}
