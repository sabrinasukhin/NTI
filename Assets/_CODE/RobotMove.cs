using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RobotMove : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 5f;

    private bool facingRight;

    public GameObject robotSprite;

    void Start()
    {
        facingRight = true;
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

        if (Input.GetKey("d"))
        {
            facingRight = true;
            gameObject.transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey("a"))
        {
            facingRight = false;
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey("s"))
        {
            gameObject.transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey("w"))
        {
            gameObject.transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
        }
    }
}
