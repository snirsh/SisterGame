﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Nun;
    public GameObject [] Candles;
    public static GameManager Instance { get; private set; }

    protected void Awake()
    {
        Instance = this;
        foreach(GameObject candle in Candles)
        {
            
        }
    }
}