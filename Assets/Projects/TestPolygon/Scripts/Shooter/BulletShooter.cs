using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    [SerializeField] private GameObject _markPrefab;

    private bool _hasHit;

    private void OnCollisionEnter(Collision collision)
    {
        //if (_hasHit) return;

        _hasHit = true;

        var rb = GetComponent<Rigidbody>();
        if(rb)
        {
            rb.useGravity = true;

            Debug.Log(collision.gameObject.name);

            var enemy = collision.gameObject.GetComponent<Enemy>();
            if (enemy)
            {
                enemy.OnHit();
            }
            
            if(collision.gameObject.tag == "Markable")
            {
                Vector3 position = collision.contacts[0].point;
                Quaternion rotation = Quaternion.LookRotation(collision.contacts[0].normal);
                Instantiate(_markPrefab, position, rotation);
            }
        }
    }
}
