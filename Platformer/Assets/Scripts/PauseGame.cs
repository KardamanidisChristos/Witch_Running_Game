using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseGame : MonoBehaviour {
    //checked
    public bool gamePaused = false;
    public AudioSource music_for_this_level;
    public GameObject pause_menu;
    public AudioSource pause_sound;
    // Update is called once per frame
    void Update () {
        //GO TO PROJECT SETTING ,THERE ARE DEFAULT BUTTONS FOR UNITY
        if (Input.GetButtonDown("Cancel")) {
            if (gamePaused == false)
            {
                pause_sound.Play();
                Time.timeScale = 0;//WE SET THE SPEED OF THE TIME TO 0
                gamePaused = true;
                Cursor.visible = true;
                music_for_this_level.Pause();
                pause_menu.SetActive(true);
            }
            else {
                pause_menu.SetActive(false);
                music_for_this_level.UnPause();
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
            }

        }
	}
    public void ResumeGame() {
        pause_menu.SetActive(false);
        music_for_this_level.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;

    }
    public void RestartLevel()
    {
        pause_menu.SetActive(false);
        music_for_this_level.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(2);//I load the redirect page

    }
    public void QuitToMenu()
    {
        pause_menu.SetActive(false);
        music_for_this_level.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);//I load the redirect page

    }
}
