using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform _weaponTransform;

    private GameObject _currentWeapon;

    public WeaponBase _currentWeaponData { get; set; }

    private void Update()
    {
        if (_currentWeaponData != null)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                var controller = _currentWeapon.GetComponent<WeaponController>();
                _currentWeaponData.Fire(controller);
            }
        }
    }

    public void SetCurrentWeapon(Weapon weapon)
    {
        _currentWeaponData = weapon.weapon;

        _currentWeapon = Instantiate(_currentWeaponData.weaponPrefab, _weaponTransform);
    }
}
