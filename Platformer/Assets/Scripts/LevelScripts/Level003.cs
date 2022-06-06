using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level003 : MonoBehaviour {

    public GameObject fadein;
	void Start () {
        RedirectToLevel.redirectToLevel = 3;
        RedirectToLevel.nextLevel = 4;//4 to credits
        StartCoroutine(fadeinOf());
    }
    
    IEnumerator fadeinOf() {

        yield return new WaitForSeconds(1f);
        fadein.SetActive(false);//we have to disable fadein animation after being executed

    }
	

}
