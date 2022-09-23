using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallWalker : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.contacts[0].normal);
    }
}
