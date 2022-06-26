using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;

    // Configurables
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void UpdateMovement()
    {
        float x = Input.GetAxis("Horizontal");
        var movement = new Vector2(x, 0);
        rb.MovePosition(rb.position + movement * Time.deltaTime * speed);
        anim.SetFloat("x", x);
    }

    void StopOnNoInput()
    {
        if (Input.GetAxis("Horizontal") == 0)
        {
            anim.SetFloat("x", 0);
            rb.velocity = Vector2.zero;
        }
    }

    // Update is called once per frame
    void FixedUpdate() {
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            UpdateMovement();
        }
        else
        {
            StopOnNoInput();
        }
        anim.SetFloat("y", rb.velocity.y);
    }
}
