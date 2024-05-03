using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Teleport : MonoBehaviour
{
    public float timer;
    public float coolDown = 2.0f;
    void Start()
    {

    }

    void Update()
    {
        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
        }
        else if (timer <= 0.0f)
        {
            timer = coolDown;
            transform.position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
        }

    }

}

