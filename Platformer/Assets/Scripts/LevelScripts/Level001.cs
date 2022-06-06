using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level001 : MonoBehaviour {

    public GameObject fadein;
	void Start () {
        RedirectToLevel.redirectToLevel = 3;
        RedirectToLevel.nextLevel = 5;
        StartCoroutine(fadeinOf());
    }
    
    IEnumerator fadeinOf() {

        yield return new WaitForSeconds(1f);
        fadein.SetActive(false);//we have to disable fadein animation after being executed

    }
	

}
