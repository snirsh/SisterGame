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
        Vector3 currentPos = Input.mousePosition;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 inputVector = new Vector2(horizontalInput, verticalInput);
        // inputVector = Vector2.ClampMagnitude(inputVector, 1);
        isoRenderer.SetDirection(inputVector);
        
        // Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        // float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        // transform.rotation = Quaternion.Euler(0, 0, transform.eulerAngles.z);
        // isoRenderer.SetDirection(dir);
    }
}
