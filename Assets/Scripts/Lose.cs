using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    // Start is called before the first frame update


    public void RegresarMenu()
    {
        SceneManager.LoadScene("Start");

    }

    public void JugardeNuevo()
    {
        SceneManager.LoadScene("Game");

    }
}
