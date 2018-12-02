using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;

    public bool canMove = true;

    public GameObject square;
    public GameObject circle;
    public GameObject triangle;

    float horizontalMove = 0f;

    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;
    
    int actualShape = 0;

	// Update is called once per frame
	void Update () {
        if (canMove)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }

            if (Input.GetButtonDown("Crouch") && actualShape == 0)
            {
                crouch = true;
            }
            else if (Input.GetButtonUp("Crouch") && actualShape == 0)
            {
                crouch = false;
            }
        }
        if (Input.GetButtonDown("Map"))
        {
            canMove = !canMove;
        }
        if(Input.GetButtonDown("ChangeLeft") && crouch == false)
        {
            actualShape++;
            if(actualShape == 3)
            {
                actualShape = 0;
            }
            ChangeShape();
        }
        else if (Input.GetButtonDown("ChangeRight") && crouch == false)
        {
            actualShape--;
            if (actualShape < 0)
            {
                actualShape = 2;
            }
            ChangeShape();
        }
	}

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    void ChangeShape()
    {
        if (actualShape == 0)
        {
            square.SetActive(true);
            triangle.SetActive(false);
            circle.SetActive(false);
        }
        else if (actualShape == 1)
        {
            square.SetActive(false);
            triangle.SetActive(true);
            circle.SetActive(false);
        }
        else if (actualShape == 2)
        {
            square.SetActive(false);
            triangle.SetActive(false);
            circle.SetActive(true);
        }
    }
}
