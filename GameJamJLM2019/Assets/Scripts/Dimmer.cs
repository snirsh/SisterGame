using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dimmer : MonoBehaviour
{
    public GameObject nunLight;
    HardLight2D candle;
    public float minRange;
    public float maxRange;
    public float timeToMove;
    float random;
    float lastRand;
    float currentTime = 0f;

    void Awake()
    {
        candle = nunLight.GetComponent<HardLight2D>();
        lastRand = candle.Range;
        random = Random.Range(minRange, maxRange);
    }

    void Update()
    {
        if (currentTime <= timeToMove)
        {
            currentTime += Time.deltaTime;
            candle.Range = Mathf.Lerp(lastRand, random, currentTime / timeToMove);
        }
        else
        {
            lastRand = random;
            random = Random.Range(minRange, maxRange);
            currentTime = 0f;
        }
    }
}