using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRotate : MonoBehaviour {
    public int rotateSpeed = 2;
	//checked
	// Update is called once per frame
	void Update () {
        //i rotate the current object in relation to the time of the game
        transform.Rotate(0,rotateSpeed*Time.timeScale,0,Space.World);
	}
}
