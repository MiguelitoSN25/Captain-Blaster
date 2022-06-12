using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public static int objeto;
    // Start is called before the first frame update
   public void IniciarJuego()
    {
        objeto = 1;
        SceneManager.LoadScene("Game");
    }
}
