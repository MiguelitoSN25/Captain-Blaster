using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject bulletPrefab;
    public float speed = 10f;
    public float xLimit = 7f;
    public float reloadTime = 0.5f;

    float elapsedTime = 0f;

    void Update()
    {
       
        elapsedTime += Time.deltaTime;

        float xInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(xInput, 0f, 0f);


        if (Input.GetButtonDown("Jump") && elapsedTime > reloadTime)
        {
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(0, 1.2f, 0);
            Instantiate(bulletPrefab, spawnPos, Quaternion.identity);
            elapsedTime = 0f; // Reset bullet firing timer
        }
    }
    // If a meteor hits the player
    void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.instance.PlayerDied();
        Destroy(gameObject);
    }
}
