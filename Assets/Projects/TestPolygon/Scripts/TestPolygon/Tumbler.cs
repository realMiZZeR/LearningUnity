using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tumbler : MonoBehaviour
{
    [SerializeField] private Transform centerOfMassPosition;

    private void Update()
    {
        GetComponent<Rigidbody>().centerOfMass = Vector3.Scale(centerOfMassPosition.localPosition, transform.localScale);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(GetComponent<Rigidbody>().worldCenterOfMass, 0.1f);
    }
}
