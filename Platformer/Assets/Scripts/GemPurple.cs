using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GemPurple : MonoBehaviour {
    //checked
    public GameObject ScoreBox;
    public AudioSource collectSound;
    void OnTriggerEnter() {
        GlobalScore.currentScore += 700;//i assign 500 to the variable currentscore in the globalscorescript
        collectSound.Play();
        Destroy(gameObject);


    }
}
