using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float maxSpeed = 3f;
    public float jumpPower = 500f;
    private float speed = 20f;

    public bool isOnGround;
    public bool canDoubleJump = false;

    private Rigidbody rb;
    private Animator animator;

    private Vector3 direction;
    public float x;
    public float y;
    public float z;


    // Use this for initialization
    void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
 //       animator = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        GetInput();
        Move();

    }


    public void Move()
    {
        x = direction.x;
        y = direction.y;
        z = direction.z;

        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void GetInput()
    {
        direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction = new Vector3(0, y, 1);
}

        if (Input.GetKey(KeyCode.A))
        {
            direction = new Vector3(-1, y, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction = new Vector3(0, y, -1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction = new Vector3(1, y, 0);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isOnGround)
            {

                rb.velocity += Vector3.up* jumpPower;
                canDoubleJump = true;
            }
            else
            {

                if (canDoubleJump)
                {
                    canDoubleJump = false;
                    rb.velocity += Vector3.up* jumpPower;

                }
            }
        }
    }

        void FixedUpdate()
    {


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collectible"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Enemy"))
        {

        }
    }
}
