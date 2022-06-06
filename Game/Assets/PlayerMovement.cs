using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public CharacterController2D obj;//A REFERENCE TO THE CONTROLLER FILE
    
    float horizontalmove = 0f;
    float runspeed = 40f;
    bool jump = false;//BY DEFAULT PLAYER DOES NOT JUMP
    bool crouch = false;//BY DEFAULT PLAYER DOES NOT CROUCH
	// Use this for initialization
	void Start () {
        
       
      
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Input.GetAxisRaw("Horizontal")); //INPUT.GETAXIS RETURNS-1,1,left right a d arrow ,DEBUG RETURNS IT TO SCREEN
        horizontalmove = Input.GetAxisRaw("Horizontal")*runspeed;
        if (Input.GetButtonDown("Jump")) {
            //jump space
            jump = true;
            //EDIT>PROJECT SETTINGS>INPUT KAI MPORW NA ALLAKSW TA INPUT GIA JUMP HORIZONTAL

        }
        if (Input.GetButtonDown("Crouch"))
        {
            //jump space
            crouch = true;
            //EDIT>PROJECT SETTINGS>INPUT KAI MPORW NA ALLAKSW TA INPUT GIA JUMP HORIZONTAL

        } else if (Input.GetButtonUp("Crouch")) {
            //THELOUME ME TO POU STAMATAME NA PATAME NA STAMATISEI NA EINAI CROUCH
            crouch = false;

        }
    }

    //FixedUpdate is fixed
    void FixedUpdate() {
        //Move(float move ,bool crouch ,bool jump)
        //Time.fixedDeltaTime-->Time since function was last called
        obj.Move(horizontalmove*Time.fixedDeltaTime,crouch,jump);
        jump = false;//GIA NA MIN PIDAW EP APEIRWN
        crouch = false;
    }
}
