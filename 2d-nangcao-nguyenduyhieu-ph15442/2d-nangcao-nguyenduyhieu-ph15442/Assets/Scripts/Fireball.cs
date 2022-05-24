using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fireball : MonoBehaviour
{
    private Rigidbody2D fireball;
    private float speed = 20f;
    public Text scoreText;
    

    [SerializeField] private Rigidbody2D body;
    
    
    // Start is called before the first frame update
    void Start()
    {
        fireball = GetComponent<Rigidbody2D>();
        body.velocity = transform.right * speed;
        scoreText.text = "Score: " + Scoring.totalSocre;
    }

    private void OnTriggerEnter(Collider2D collider)
    {
        if (collider.tag =="Respawn")
        {
            Scoring.totalSocre += 1;
            scoreText.text = "Score: " + Scoring.totalSocre;
            collider.gameObject.SetActive(false);
        }
    }
}
