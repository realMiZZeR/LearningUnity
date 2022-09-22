using UnityEngine;

public abstract class WeaponBase : ScriptableObject
{
    public abstract string weaponName { get; }
    public abstract int bulletAmount { get; set; }
    public abstract int maxBulletAmount { get; }
    public abstract float fireDelay { get; }
    public abstract float reloadTime { get; }
    public abstract GameObject weaponPrefab { get; }
    public abstract GameObject bulletPrefab { get; }

    public abstract void Fire(WeaponController controller);
    public abstract void Reload();
    public abstract void Grab();
}
