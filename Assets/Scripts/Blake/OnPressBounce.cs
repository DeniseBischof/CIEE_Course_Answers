using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPressBounce : MonoBehaviour
{
    private Rigidbody playerRigidbody;

    public float jumpForce = 200f;
    Vector2 force;

    public bool isOnGround;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && isOnGround)
        {
            force = new Vector2(0, jumpForce);
        }
        else
        {
            force = new Vector2(0, 0);
        }

        playerRigidbody.AddForce(force);
    }
}
