using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuFunction : MonoBehaviour {
    //checked
    public AudioSource clickSound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PlayGame() {
        clickSound.Play();
        //we assign the number 3 which to the redirection script "RedirectToLevel" in order to load the 3 scene which is the first level
        RedirectToLevel.redirectToLevel = 3;
        SceneManager.LoadScene(2);
    }
    public void QuitMyGame() {
        Application.Quit();
    }
    public void startplayingcreds() {
        clickSound.Play();
        SceneManager.LoadScene(4);

    }
}
