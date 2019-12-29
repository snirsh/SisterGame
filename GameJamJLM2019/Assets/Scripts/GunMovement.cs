using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovement : MonoBehaviour
{
    IsometricCharacterRenderer isoRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativeLookAtPos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        var angle = Mathf.Atan2(relativeLookAtPos.y, relativeLookAtPos.x);
        transform.rotation = Quaternion.Euler(0, 0, angle * Mathf.Rad2Deg);
        Debug.DrawLine(transform.position, relativeLookAtPos, Color.red);
        Debug.Log(relativeLookAtPos);
    }
}
