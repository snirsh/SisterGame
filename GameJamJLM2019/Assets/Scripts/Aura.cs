using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aura : MonoBehaviour
{
    public GameObject nunLight;
    public GameObject crossShadow;
    public float speed;
    HardLight2D aura;
    SpriteRenderer srCross;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake(){
        aura = nunLight.GetComponent<HardLight2D>();
        srCross = crossShadow.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
         aura.Intensity = Mathf.Lerp(aura.Intensity, 0f, Time.time * speed);
         srCross.color -= new Color(0,0,0,Time.time * speed);
    }
}
