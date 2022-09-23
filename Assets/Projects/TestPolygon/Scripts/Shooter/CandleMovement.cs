using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleMovement : MonoBehaviour
{

    void Update()
    {
        transform.position = new Vector3(0, Mathf.Lerp(0f, 1f, 0.2f), 0);
    }
}
