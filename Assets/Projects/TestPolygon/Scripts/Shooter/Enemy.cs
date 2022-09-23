using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private MeshRenderer _currentMesh;
    private Color _meshColor;

    private void Start()
    {
        _currentMesh = GetComponent<MeshRenderer>();
        _meshColor = _currentMesh.material.color;
    }

    public void OnHit()
    {
        _currentMesh.material.color = Color.red;
        StartCoroutine(WaitAfterHit());
    }

    private IEnumerator WaitAfterHit()
    {
        yield return new WaitForSeconds(2f);

        _currentMesh.material.color = _meshColor;
    }
}
