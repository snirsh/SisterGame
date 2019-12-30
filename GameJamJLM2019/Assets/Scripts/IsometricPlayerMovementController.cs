using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricPlayerMovementController : MonoBehaviour
{

    public float movementSpeed = 1f;
    IsometricCharacterRenderer isoRenderer;

    Rigidbody2D rbody;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        isoRenderer = GetComponentInChildren<IsometricCharacterRenderer>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 currentPos = rbody.position;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if ((Input.GetKeyDown(KeyCode.UpArrow) ||
            Input.GetKeyDown(KeyCode.LeftArrow) ||
            Input.GetKeyDown(KeyCode.DownArrow) ||
            Input.GetKeyDown(KeyCode.RightArrow)) && !AudioManager.Instance.SFX_Source.isPlaying)
        {
            Debug.Log(AudioManager.Instance.SFX_Source.isPlaying);

            AudioManager.Instance.PlaySingle("SFX_Movement");
        }

        if (Input.GetKey(KeyCode.UpArrow) == false &&
            Input.GetKey(KeyCode.LeftArrow) == false &&
            Input.GetKey(KeyCode.DownArrow) == false &&
            Input.GetKey(KeyCode.RightArrow) == false)
        {
            AudioManager.Instance.SFX_Source.Stop();
        }

        Vector2 inputVector = new Vector2(horizontalInput, verticalInput);
        inputVector = Vector2.ClampMagnitude(inputVector, 1);
        Vector2 movement = inputVector * movementSpeed;
        Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
        isoRenderer.SetDirection(movement);
        rbody.MovePosition(newPos);
    }
}
