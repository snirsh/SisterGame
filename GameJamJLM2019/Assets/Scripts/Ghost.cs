using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public GameObject target;
    public float speed = 0.4f;
    Vector2 position;
    void Start()
    {
        position = gameObject.transform.position;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.gameObject.transform.position.x, target.gameObject.transform.position.y), step);
    }
}
