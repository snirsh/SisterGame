using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Nun;
    public GameObject [] Candles;

    public GameObject [] Ghosts;
    private int numGhosts;
    public Canvas winCanvas;
    public Canvas loseCanvas;
    public static GameManager Instance { get; private set; }

    protected void Awake()
    {
        Instance = this;
        numGhosts = Ghosts.Length;
    }

    public void GhostKilled()
    {
        numGhosts--;

        if(numGhosts == 0)
        {
            winCanvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void NunDied()
    {
        loseCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}