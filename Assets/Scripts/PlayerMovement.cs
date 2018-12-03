using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;

    public bool canMove = true;

    public GameObject square;
    public GameObject circle;
    public GameObject triangle;
 
    public Transform wallCheckPoint;
    public bool wallCheck;
    public LayerMask wallLayerMask;

    public float horizontalMove = 0f;

    public float runSpeed = 40f;
    public bool jump = false;
    bool crouch = false;
    bool grounded;

    bool lookingRight = true;

    bool doGroundPound = false;
    public bool doingGroundPound = false;

    public int actualShape = 0;

    public bool megaJump = false;

    GameManager gm;

    public Animator anim;

    void Awake()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        anim = GetComponent<Animator>();
    }

	// Update is called once per frame
	void Update () {
        if (canMove)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            if (Input.GetButtonDown("Jump") && !controller.wallSliding && !doGroundPound)
            {
                jump = true;
            }
            if (gm.pickUp1Acquired)
            {
                if (Input.GetButtonDown("Crouch") && actualShape == 0)
                {
                    crouch = true;
                    anim.SetBool("Crouch", true);
                }
                else if (Input.GetButtonUp("Crouch") && actualShape == 0)
                {
                    crouch = false;
                }
            }  
        }
        if (Input.GetButtonDown("Map"))
        {
            canMove = !canMove;
            if (!canMove)
            {
                GameObject.Find("CanvasMap").GetComponent<Canvas>().enabled = true;
            }
            else if(canMove)
            {
                GameObject.Find("CanvasMap").GetComponent<Canvas>().enabled = false;
            }
            gm.CheckMap();
            
        }
        if (gm.pickUp2Acquired||gm.pickUp3Acquired)
        {
            if (Input.GetButtonDown("ChangeRight") && crouch == false && GetComponent<CharacterController2D>().m_Grounded)
            {
                actualShape++;
                if (gm.pickUp3Acquired)
                {
                    if (actualShape == 3)
                    {
                        actualShape = 0;
                    }
                }
                else if (gm.pickUp2Acquired)
                {
                    if (actualShape == 2)
                    {
                        actualShape = 0;
                    }
                }
                
                ChangeShape();
            }
            else if (Input.GetButtonDown("ChangeLeft") && crouch == false && GetComponent<CharacterController2D>().m_Grounded)
            {
                actualShape--;
                if (gm.pickUp3Acquired)
                {
                    if (actualShape < 0)
                    {
                        actualShape = 2;
                    }
                }
                else if (gm.pickUp2Acquired)
                {
                    if (actualShape < 0)
                    {
                        actualShape = 1;
                    }
                }

                
                
                ChangeShape();
            }
        }
        
        if (!GetComponent<CharacterController2D>().m_Grounded && actualShape == 1)
        {
            wallCheck = Physics2D.OverlapCircle(wallCheckPoint.position, 0.1f, wallLayerMask);
        }
        if (!wallCheck || controller.m_Grounded)
        {
            controller.wallSliding = false; 
        }
        if (Input.GetButtonDown("Fire1") && actualShape == 2 && !doingGroundPound)
        {
            if (!controller.m_Grounded)
            {
                megaJump = true;
                doGroundPound = true;
                doingGroundPound = true;
            }
        }

	}

    void FixedUpdate()
    {
        if (!doingGroundPound)
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
            jump = false;
        }
        
        if (doGroundPound)
        {
            GroundPoundAttack();
            
        }
        doGroundPound = false;
        if (controller.m_Grounded && doingGroundPound)
        {
            doingGroundPound = false;
            controller.CompleteGroundPound();
        }
    }

    private void GroundPoundAttack()
    {
        controller.Stop();
        controller.StartCoroutine("DropAndSmash");
    }

    public void ChangeShape()
    {
        if (actualShape == 0)
        {
            square.SetActive(true);
            triangle.SetActive(false);
            circle.SetActive(false);
        }
        else if (actualShape == 1 && gm.pickUp2Acquired)
        {
            square.SetActive(false);
            triangle.SetActive(true);
            circle.SetActive(false);
        }
        else if (actualShape == 2 && gm.pickUp3Acquired)
        {
            square.SetActive(false);
            triangle.SetActive(false);
            circle.SetActive(true);
        }
    }
}
