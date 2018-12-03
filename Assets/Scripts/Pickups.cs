using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour {

    private PlayerMovement player;
    private GameManager gm;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.pickUpUp = true;
        if (this.gameObject.CompareTag("PickUp1"))
        {
            gm.pickUp1Acquired = true;
        }
        else if (this.gameObject.CompareTag("PickUp2"))
        {
            gm.pickUp2Acquired = true;
        }
        else if (this.gameObject.CompareTag("PickUp3"))
        {
            gm.pickUp3Acquired = true;
        }
        else if (this.gameObject.CompareTag("Star"))
        {
            gm.numberStars++;
        }
        Destroy(this.gameObject);
    }
}
