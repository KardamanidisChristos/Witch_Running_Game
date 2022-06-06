using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RedirectToLevel : MonoBehaviour {
    //checked
    public static int redirectToLevel ;
    public static int nextLevel;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (redirectToLevel==3) {
            //we load the same scene when we die
            SceneManager.LoadScene(redirectToLevel);
        }
	}
}
