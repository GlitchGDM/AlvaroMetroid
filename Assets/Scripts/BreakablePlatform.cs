using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakablePlatform : MonoBehaviour {

    private PlayerMovement player;
    private CharacterController2D chara;
    private GameManager gm;

    public bool YesIs0;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        chara = GameObject.Find("Player").GetComponent<CharacterController2D>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (player.doingGroundPound || player.megaJump)
        {
            if (this.gameObject.name == "BreakableBlock")
            {
                gm.somethingBroke = true;
            }
            else if(this.gameObject.name == "BreakableBlock1")
            {
                gm.somethingBroke1 = true;
            }
            chara.m_Grounded = true;
            Destroy(this.gameObject);
        }
    }
}
