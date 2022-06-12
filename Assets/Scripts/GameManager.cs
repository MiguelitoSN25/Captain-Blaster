using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;
    public Text gameOverText;
    private int score = 0;
    public bool IsGameOver = false;
    public float meteorSpeed = -2f;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
     void Update()
    {
        if (GameManager.instance.IsGameOver && Input.GetButton("Jump"))
        {
            SceneManager.LoadScene("Game");
        }
        {

        }
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " +  score;

        meteorSpeed += score / -50f;
    }
    public void PlayerDied()
    {
        gameOverText.enabled = true;
        // This freezes the game
        Time.timeScale = 0;
    }

}
