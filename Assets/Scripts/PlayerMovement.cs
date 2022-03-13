using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxisRaw("Horizontal");
        float ySpeed = Input.GetAxisRaw("Vertical");

        rb.AddForce(new Vector2(xSpeed * speed, 0));
        rb.AddForce(new Vector2(0, ySpeed * speed));
    }
}
