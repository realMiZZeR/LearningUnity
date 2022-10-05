using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceMaybe : MonoBehaviour
{
    private float target;
    private float countDown;

    private void Start()
    {
        countDown = transform.localScale.y;
    }

    private void Update()
    {
        if (transform.position.y >= transform.localScale.y - 1)
            return;

        transform.Translate(Vector3.up * Time.deltaTime);
    }
}
