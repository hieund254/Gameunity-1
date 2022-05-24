using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    float dirx;
    [HideInInspector] public bool mustpatrol;
    public float moveSpeed = 0.1f;

    public Rigidbody2D rb;
    public Transform checkground;
    private bool musturn;
    public LayerMask groudLayer;
    private bool facingRight = false;

    Vector3 localScale;

    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        dirx = -1f;
        mustpatrol = true;
    }
    void Update()
    {
        if (mustpatrol)
        {
            Patrol();
        }
        
    }
    private void FixeUpdate()
    {
        if (mustpatrol)
        {
            musturn = !Physics2D.OverlapCircle(checkground.position, 0.1f, groudLayer);
        }
    }
    void Patrol()
    {
        if (musturn)
        {
            Flip();
        }
        rb.velocity = new Vector2(moveSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }
    void Flip()
    {
        mustpatrol = false;
        transform.localScale = new Vector2(transform.localScale.x*0.1f, transform.localScale.y);
        moveSpeed *= -1;
        mustpatrol = true;
    }
    // Update is called once per frame

}
     

