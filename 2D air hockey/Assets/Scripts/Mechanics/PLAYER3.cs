using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER3 : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    private float vx1;
    private float vx2;
    private float vx;

    private float vy1;
    private float vy2;
    private float vy;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //PLAYER 1
        //KeyDown
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            vy1 = vy1 - 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            vy2 = vy2 + 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            vx1 = vx1 - 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            vx2 = vx2 + 1.0f;
        }
        //KeyUp
        if (Input.GetKeyUp(KeyCode.Keypad5))
        {
            vy1 = 0.0f;
        }
        if (Input.GetKeyUp(KeyCode.Keypad8))
        {
            vy2 = 0.0f;
        }
        if (Input.GetKeyUp(KeyCode.Keypad4))
        {
            vx1 = 0.0f;
        }
        if (Input.GetKeyUp(KeyCode.Keypad6))
        {
            vx2 = 0.0f;
        }

        vy = vy1 + vy2;
        vx = vx1 + vx2;

        moveVelocity = new Vector2(vx, vy).normalized * speed;

        //Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //moveVelocity = moveInput.normalized * speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
