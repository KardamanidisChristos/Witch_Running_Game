using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalScore : MonoBehaviour {
    //checked
    public GameObject scoreBox;
    public static int currentScore;//this is the score that is being modified by the script for every gem
    public int internalScore;//this variable is assigned to the scorebox text in the canvas
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        internalScore = currentScore;
        scoreBox.GetComponent<Text>().text = ""+internalScore;
    }
}
