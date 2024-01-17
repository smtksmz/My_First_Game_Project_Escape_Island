using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_controller : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 4.0f;
    private bool jump;
    private bool grounded=true;

    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 move;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

   
    private void FixedUpdate()
    {
        rb.velocity=move*speed;
        if(jump) 
        {
            rb.velocity=new Vector2(rb.velocity.x,jumpForce);
            jump = false;
        }
    }
 
    private void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"),rb.velocity.y*0.20f);
        if(rb.velocity.x > 0 ) 
        {
            animator.SetFloat("speed", speed);
            spriteRenderer.flipX = false;
        }
        else if (rb.velocity.x < 0)
        {
            animator.SetFloat("speed", speed);
            spriteRenderer.flipX = true;
        }
        else if(rb.velocity.x ==0)
        {
            animator.SetFloat("speed", 0);
        }

        if (grounded && Input.GetKey(KeyCode.W))
        {
            jump = true;
            grounded = false;
            //anim.SetTrigger("jump");
            //anim.SetBool("grounded", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            //anim.SetBool("grounded", true);
            grounded = true;
        }
    }
}
