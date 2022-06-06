using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour {
    //checked
    public float rotateSpeed = 1f;//WE HAVE INITIALISED THE TIME OF THE SKY
	// Use this for initialization
    //script is executed when attached to an object
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Time.time=game pause ,we want sky to rotate 2 times faster,it goes to the skybox of the current scene and it starts moving
        
        RenderSettings.skybox.SetFloat("_Rotation",Time.time*rotateSpeed);
	}
}
