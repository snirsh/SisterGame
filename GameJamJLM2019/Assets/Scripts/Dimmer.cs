using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dimmer : MonoBehaviour
{
    public GameObject nunLight;
    HardLight2D candle;
    float minRange = 1.95f;
    float maxRange = 2.05f;
    float random = 1.9f;
    const float DEFAULT_TIME = 1f;
    float time = DEFAULT_TIME;
    float lastRand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        candle = nunLight.GetComponent<HardLight2D>();
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        // time -= Time.deltaTime;
        // if(time < 0){
        lastRand = random;
        random = Random.Range(minRange, maxRange);
        Debug.Log(random);
            // candle.Range = Mathf.Lerp(minRange, maxRange, Time.time * 0.1f);
        candle.Range = Mathf.Lerp(lastRand, random, Time.time);
            // time = DEFAULT_TIME;
        // }
        // Debug.Log(time);
    }
}
