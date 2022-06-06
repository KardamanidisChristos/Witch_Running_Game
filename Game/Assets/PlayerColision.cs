using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColision : MonoBehaviour {
    public PlayerMovement movement;
    
    void OnCollisionEnter2D(Collision2D col) {

        Debug.Log("WE HIT SOMETHING");
        if (col.collider.tag=="enemy") {
            Debug.Log("WE HIT enemy");
            
            Debug.Log("Movement Disabled");
            game_over();
        }
        if (col.collider.tag == "Finish") {
            Debug.Log("WE reached end");
            finish();
        }
        if (col.collider.tag == "sea")
        {
            Debug.Log("WE falled to the sea");
            game_over();
        }

    }
    private void game_over() {
        movement.enabled = false;
        //WE DEFINED AN OBJECT GAME MANAGER AND WE ACCESS IT WITH THIS COMMAND
        FindObjectOfType<GameManager>().EndGame();

    }
    private void finish() {
        movement.enabled = false;
        //WE DEFINED AN OBJECT GAME MANAGER AND WE ACCESS IT WITH THIS COMMAND
        FindObjectOfType<GameManager>().won();


    }
}
