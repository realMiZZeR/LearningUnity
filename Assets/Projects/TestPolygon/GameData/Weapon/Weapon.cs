using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public WeaponBase weapon;

    private Player _player;

    public WeaponController weaponController { get; private set; }

    private void Awake()
    {
        var prefab = Instantiate(weapon.weaponPrefab, transform);
        prefab.TryGetComponent<WeaponController>(out WeaponController _weaponController);
        weaponController = _weaponController;
    }

    private void OnTriggerEnter(Collider collider)
    {
        _player = collider.gameObject.GetComponent<Player>();
        if (_player)
        {
            _player.SetCurrentWeapon(this);
        }
    }
}
