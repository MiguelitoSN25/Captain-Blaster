using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour
{
    public GameObject selectedskin;
    public GameObject player;

    private Sprite playersprite;
    // Start is called before the first frame update
    void Start()
    {
        playersprite = selectedskin.GetComponent<SpriteRenderer>().sprite;

        player.GetComponent<SpriteRenderer>().sprite = playersprite;
    }

}
