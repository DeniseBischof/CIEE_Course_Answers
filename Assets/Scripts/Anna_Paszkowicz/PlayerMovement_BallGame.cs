using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_BallGame : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float moveSpeed = 400f;
    public float jumpForce = 200f;

    public bool isOnGround;

    Vector2 force;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (playerRigidbody!= null)
        {
            ApplyInput();

        }
        else
        {
            Debug.LogWarning("Rigid body not attached to the player" + gameObject.name);
        }
         
    }

    public void ApplyInput()
    {
        float xInput = Input.GetAxis("Horizontal");
        //float yInput = Input.GetAxis("Vertical");

        float xForce = xInput * moveSpeed * Time.deltaTime;
        //float yForce = yInput * moveSpeed * Time.deltaTime;
          

        if (Input.GetKeyDown("space") && isOnGround)
        {
            force = new Vector2( xForce, jumpForce);
        }
        else
        {
            force = new Vector2(xForce, 0);
        }

        playerRigidbody.AddForce(force);

    }
}
