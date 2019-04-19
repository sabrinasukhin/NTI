using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RobotMove : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 5f;

    private bool facingRight;
    private bool isHolding;

    public GameObject robotSprite;

    void Start()
    {
        facingRight = true;
        isHolding = false;
    }

    void Update()
    {
        if (facingRight)
        {
            robotSprite.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            robotSprite.GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            facingRight = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            facingRight = false;
        }

        if (Input.GetKey(KeyCode.E) && isHolding)
        {

        }

        rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Hazard" || other.gameObject.tag == "Toy")
        {
            if (Input.GetKey(KeyCode.E))
            {
                other.transform.parent = transform;
                other.transform.localPosition = new Vector3(0.03f, 0, 2);
                isHolding = true;
            }
        }
    }
}
