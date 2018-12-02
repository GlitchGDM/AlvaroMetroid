using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingPlatform : MonoBehaviour {

    private PlayerMovement player;
    private CharacterController2D chara;

    private bool goodJump = false;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        chara = GameObject.Find("Player").GetComponent<CharacterController2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (player.megaJump && player.actualShape == 2)
        {
            player.jump = true;
            chara.m_JumpForce = 1400f;
            goodJump = true;
            StartCoroutine(wait());
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (goodJump)
        {
            Debug.Log("adios");
            player.megaJump = true;
            goodJump = false;
        }
       
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.2f);
        player.megaJump = false;
        chara.m_JumpForce = 700f;
    }

}
