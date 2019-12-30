using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerSorter : MonoBehaviour
{
    SpriteRenderer rend;
    SpriteRenderer[] rends;
    bool isStatic = true;
    void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
        rends = GetComponentsInChildren<SpriteRenderer>();
        if (isStatic)
            SetSortingOrder();
    }
    void LateUpdate()
    {
        if (!isStatic)
            SetSortingOrder();
    }

    void SetSortingOrder()
    {
        var order = -(int)(transform.position.y * 100);

        if (rend != null)
        {
            rend.sortingOrder = order;
        }

        foreach (var rend_ in rends)
        {
            rend_.sortingOrder = order;
        }
    }
}
