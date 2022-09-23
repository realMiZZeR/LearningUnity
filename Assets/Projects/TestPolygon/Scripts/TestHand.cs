using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHand : MonoBehaviour
{
    public LayerMask wallLayer;

    private void FixedUpdate()
    {
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, .1f, wallLayer))
        {
            Debug.Log("p: " + hit.point);
            Debug.Log("n: "+ hit.point.normalized);
            Debug.Log("m: " + hit.point.magnitude);
            Debug.DrawRay(transform.position, transform.forward * .1f, Color.red);
            transform.position = hit.point;
            transform.rotation = Quaternion.LookRotation(hit.point.normalized);
        }
    }
}
