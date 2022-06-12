using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float speed = 10f;
    GameManager gameManager;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    }



    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject); // Destroy the meteor
        GameManager.instance.AddScore();   // Increment the score
        Destroy(gameObject); // Destroy the bullet
    }
}

