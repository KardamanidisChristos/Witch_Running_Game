﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GemAzure : MonoBehaviour {
    //checked
    public GameObject ScoreBox;
    public AudioSource collectSound;
    void OnTriggerEnter() {
        GlobalScore.currentScore += 1500;
        collectSound.Play();
        Destroy(gameObject);


    }
}
