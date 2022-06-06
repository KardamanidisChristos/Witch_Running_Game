using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RollMyCredits : MonoBehaviour {
    public GameObject cred;
	// Use this for initialization
	void Start () {
        StartCoroutine(roll());
	}

    IEnumerator roll() {


        yield return new WaitForSeconds(0.7f);
        cred.SetActive(true);
        yield return new WaitForSeconds(15.5f);
        SceneManager.LoadScene(1);
    }
}
