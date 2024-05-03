using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    public Vector3 targetScale;
    // Start is called before the first frame update
    void Start()
    {
        targetScale = new Vector3(5.0f, 5.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime);
    }
}
