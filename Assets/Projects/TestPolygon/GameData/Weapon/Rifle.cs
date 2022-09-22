using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Rifle", menuName = "Data/New Rifle")]
public class Rifle : WeaponBase
{
    [SerializeField] private string _weaponName;
    [SerializeField] private GameObject _weaponPrefab;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private int _bulletAmount;
    [SerializeField] private int _maxBulletAmount = 30;
    [SerializeField] private float _reloadTime;
    [SerializeField] private float _fireDelay;

    public override string weaponName => _weaponName;
    public override int bulletAmount 
    {
        get
        {
            return _bulletAmount;
        }
        set
        {
            _bulletAmount = value;
        }
    }
    public override int maxBulletAmount => _maxBulletAmount;
    public override float reloadTime => _reloadTime;
    public override GameObject weaponPrefab => _weaponPrefab;
    public override GameObject bulletPrefab => _bulletPrefab;
    public override float fireDelay => _fireDelay;

    public override void Fire(WeaponController controller)
    {
        if(bulletAmount != 0)
        {
            _bulletAmount--;
            var bullet = Instantiate(bulletPrefab, controller.bulletSpawnPoint);
            var bulletRb = bullet.GetComponent<Rigidbody>();

            bulletRb.AddForceAtPosition(bullet.transform.forward * 100f, controller.bulletSpawnPoint.position, ForceMode.Impulse);
        }
        else
        {
            Reload();
        }
    }

    public override void Reload()
    {
        _bulletAmount = maxBulletAmount;
    }

    public override void Grab()
    {
        
    }
}
