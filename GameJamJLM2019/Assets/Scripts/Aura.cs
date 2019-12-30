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
    float crossAlphaDefault;

    // Start is called before the first frame update
    void Start()
    {
        crossAlphaDefault = srCross.color.a;
    }

    void Awake(){
        aura = nunLight.GetComponent<HardLight2D>();
        srCross = crossShadow.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        aura.Intensity = Mathf.Lerp(aura.Intensity, 0f, 0.0012f);
        srCross.color -= new Color(0,0,0, 0.0008f);
        if(aura.Intensity == 0 || srCross.color.a == 0)
        {
            GameManager.Instance.NunDied();
        }
    }

    public void refreshLight()
    {
        aura.Intensity = 0.5f;
        srCross.color = new Color(0, 0, 0, crossAlphaDefault);
    }
}
