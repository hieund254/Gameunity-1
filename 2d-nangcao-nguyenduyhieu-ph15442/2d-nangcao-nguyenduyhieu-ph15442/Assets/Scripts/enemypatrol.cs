using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypatrol : MonoBehaviour
{
    public float speed = 2f;

    public Rigidbody2D rb;

    public Transform checkpos;

    private bool isfaceRight = true;
    public LayerMask GroundLayerMask;

    private RaycastHit2D hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hit = Physics2D.Raycast(checkpos.position, -transform.up, 1f, GroundLayerMask);
    }

    private void FixedUpdate()
    {
        if (hit.collider !=false)
        {
            if (isfaceRight)
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
        }
        else
        {
            isfaceRight = !isfaceRight;
            transform.localScale = new Vector3(-transform.localScale.x,transform.localScale.y);
        }
    }
}
