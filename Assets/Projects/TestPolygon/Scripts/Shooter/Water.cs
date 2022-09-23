using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public float repulsiveForce;

    private MeshRenderer _currentMesh;
    private Color _meshColor;

    private void OnTriggerEnter(Collider other)
    {
        _currentMesh = other.GetComponent<MeshRenderer>();
        _meshColor = _currentMesh.material.color;
        _currentMesh.material.color = Color.blue;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody == null) return;

        other.attachedRigidbody.AddForce(Vector3.up * repulsiveForce);
    }

    private void OnTriggerExit(Collider other)
    {
        _currentMesh.material.color = _meshColor;
    }
}
