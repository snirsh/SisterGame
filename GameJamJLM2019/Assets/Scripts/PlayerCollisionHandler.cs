using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    public GameObject nunLightsAndShadows;
    private int life = 2;
    public void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name.Contains("Candle"))
        {
            col.gameObject.GetComponent<Candle>().LightCandle();
            nunLightsAndShadows.gameObject.GetComponent<Aura>().refreshLight();
        }
        if(col.gameObject.name.Contains("Ghost"))
        {
            life--;
            if(life == 0){
                GameManager.Instance.NunDied("life");
            }
        }
    }
}
