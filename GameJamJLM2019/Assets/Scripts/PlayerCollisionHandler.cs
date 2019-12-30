using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name.Contains("Candle"))
        {
            col.gameObject.GetComponent<Candle>().LightCandle();
        }
    }
}
