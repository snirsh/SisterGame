using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    public GameObject flames;
    public GameObject leftFlame;
    public GameObject rightFlame;
    public GameObject shadow;
    
    // Start is called before the first frame update
    void Start()
    {
        flames.SetActive(false);
        leftFlame.SetActive(false);
        rightFlame.SetActive(false);
        shadow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LightCandle()
    {
        Debug.Log("I AM HERE!");
        flames.SetActive(true);
        leftFlame.SetActive(true);
        rightFlame.SetActive(true);
        shadow.SetActive(true);
    }
}
