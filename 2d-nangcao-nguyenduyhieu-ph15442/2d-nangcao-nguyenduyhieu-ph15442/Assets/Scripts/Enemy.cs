using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private SpriteRenderer _renderer;
    
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Debug.Log(gameObject);
            var explosion = Instantiate(_renderer, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(col.gameObject);
            Destroy(explosion, 0.7f);
        }

        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Animator>().SetTrigger("dead");
        }
    }
}
