using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller;
    
    
    public float runSpeed = 20f;
    

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    bool raakHetScherm = false;


    // Update is called once per frame
    void Update()
    {
        //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        horizontalMove = runSpeed;

        if (Input.touchCount > 0 && raakHetScherm == false)
        {
          
             
            jump = true;
            raakHetScherm = true;
            
            
             
        }
        if(Input.touchCount == 0)
        {
            raakHetScherm = false;
            Debug.Log(Input.touchCount);
        }


        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    public void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        //PlayerCamera.transform. = new Vector3(horizontalMove, 0, 0);

    }
}



