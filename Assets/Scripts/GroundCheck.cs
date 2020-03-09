using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

    private PlayerMovement player;

    [SerializeField]
    private GameObject Player;

	// Use this for initialization
	void Start () {
        player = gameObject.GetComponentInParent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            player.isOnGround = true;
            Debug.Log("Is on Ground");
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            player.isOnGround = true;
            Debug.Log("Is on Ground");
        }

    }

    private void OnTriggerExit(Collider collision)
    {
        player.isOnGround = false;
        
    }

}
