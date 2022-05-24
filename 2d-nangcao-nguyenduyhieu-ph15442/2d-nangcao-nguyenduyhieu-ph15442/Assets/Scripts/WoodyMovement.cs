using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodyMovement : MonoBehaviour
{
    AudioSource Sourse;
    public AudioClip volume;

    private float directionX, directionY, moveSpeed;

    private Animator animator;

    private SpriteRenderer rdr;

    private bool faceRight = false;

    [SerializeField] private Weapon Weapon;

    private Rigidbody2D _rb;

    private bool isGrounded;
   

    private void Start()
    {
        animator = GetComponent<Animator>();

        rdr = GetComponent<SpriteRenderer>();

        moveSpeed = 3f;

        _rb = GetComponent<Rigidbody2D>();

        isGrounded = true;
        Sourse = GetComponent<AudioSource>();
       
    }

    private void Update()
    {
        directionX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;

        directionY = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + directionX, transform.position.y + directionY);

        if (directionX < 0 && faceRight == false)
        {
            transform.Rotate(0f, -180f, 0f);
            faceRight = true;
        }
        else if (directionX > 0 && faceRight == true)
        {
            transform.Rotate(0f, 180f, 0f);
            faceRight = false;
        }

        if (directionX != 0 || directionY != 0)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
        

        if (Input.GetKeyDown(KeyCode.F) && !animator.GetCurrentAnimatorStateInfo(0).IsName("Use Skill"))
        {
            
          
          animator.SetBool("isWalking", false);
            animator.SetTrigger("use_skill");
        }
        // FreezePosition();  

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            _rb.velocity = Vector2.up * 20f;
            isGrounded = false;
        }

        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void FreezePosition()
    {
        if (transform.position.y < -3.077766)
        {
            transform.position = new Vector3(transform.position.x, -3.077766f, 0);
        }

        if (transform.position.y > 0.4322623)
        {
            transform.position = new Vector3(transform.position.x, 0.4322623f, 0);
        }
    }

    void WoodyDead()
    {
        // Destroy(gameObject);
        Debug.Log("Triggered");
    }
}