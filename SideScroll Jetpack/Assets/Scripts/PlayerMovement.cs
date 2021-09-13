using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float burst;

    public float moveSpeed;
    public float fuel;

    public Rigidbody2D rb;
    Vector2 movement;

    private bool isGrounded;
    private bool hasFuel;






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;
    }
    private void FixedUpdate()
    {
        Vector2 temp = new Vector2(movement.x * moveSpeed * Time.deltaTime, 0f);
        rb.position += temp;
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * burst, ForceMode2D.Force);
        }
    }
}
