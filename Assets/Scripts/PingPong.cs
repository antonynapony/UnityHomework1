using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float speed = 5.0f;

    void Start()
    {
        startPosition = transform.position;
        endPosition = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f)) * Time.deltaTime;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPosition, speed * Time.deltaTime);
        if (transform.position == endPosition)
        {
            endPosition = startPosition;
        }
    }
}
