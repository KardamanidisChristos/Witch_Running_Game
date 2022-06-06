using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashToMenu : MonoBehaviour {
    //checked
    //SCRIPT FROM ONE MENU TO ANOTHER,SPLASH TO MENU
    public GameObject mylogo;
	// Use this for initialization
	void Start () {
        StartCoroutine(splash_screen_runner());
	}

    IEnumerator splash_screen_runner() {
        //THE TOTAL TIME DEPENDS ON THE TIME OF THE ANIMATION
        yield return new WaitForSeconds(0.5f);
        mylogo.SetActive(true);//ENABLE THE LOGO WHICH WILL LOOP FOR SOME TIME
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(1);//I LOAD SCENE NUMBER 1 WHICH IS THE MAIN MENU,FROM BUILD SETTINGS
    }
}
