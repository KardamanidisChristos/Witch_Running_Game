using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FinishLevel : MonoBehaviour {

    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeleft;
    public GameObject score;
    public GameObject finalScore;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;
    public GameObject levelblocker;
    public GameObject fadeout;


    void OnTriggerEnter() {
        GetComponent<BoxCollider>().enabled = false;//when game ends  we have to disable the collider of the finishing line
        levelblocker.SetActive(true);//i enable the blocker which is around my player
        levelblocker.transform.parent = null;//i detach blocker from the player ,and stops being movable with the player,and player stops moving
        timeCalc =GlobalTimer.extendScore*100;
        timeleft.GetComponent<Text>().text = "Time Left: "+ GlobalTimer.extendScore + " x100";
        score.GetComponent<Text>().text = "Score" + GlobalScore.currentScore;
        totalScored = GlobalScore.currentScore + timeCalc;
        finalScore.GetComponent<Text>().text = "Total score"+totalScored;
    levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        //when i start a coroutine it means that the function called has to be completed in one frame update
        StartCoroutine(CalculateScore());
    }
    //if i implement enumerator i can use for each statament for this
    IEnumerator CalculateScore() {
        timeleft.SetActive(true);
        //yield statement has the abillity to stop the coroutine
        yield return new WaitForSeconds(0.5f);
        score.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        finalScore.SetActive(true);
        yield return new WaitForSeconds(2f);
        fadeout.SetActive(true);
        yield return new WaitForSeconds(2f);
        GlobalScore.currentScore = 0;//when i die  i set the score to 0
        SceneManager.LoadScene(RedirectToLevel.nextLevel);
    }

}
