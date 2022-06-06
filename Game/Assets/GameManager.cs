using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    //custom
    public void EndGame() {

        Debug.Log("GAME OVER");
        Restart();
    }
    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void won() {

        SceneManager.LoadScene("wpage");

    }
}
