using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject bulletPrefab;
    [SerializeField] private float _bulletSpeed = 10f;
    public void Generate()
    {
        var bullet = Instantiate(bulletPrefab);
        bullet.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * _bulletSpeed);
    }
}
