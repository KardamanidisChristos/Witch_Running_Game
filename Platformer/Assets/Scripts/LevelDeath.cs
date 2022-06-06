using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelDeath : MonoBehaviour {
    public GameObject youfell;
    public GameObject LevelAudio;
    public GameObject fadeOut;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter() {

        StartCoroutine(YouFellOff());
        
    }
    IEnumerator YouFellOff() {
        youfell.SetActive(true);
        LevelAudio.SetActive(false);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        GlobalScore.currentScore = 0;//when i die  i set the score to 0
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
    }
}
