using UnityEngine;

public class PlayerShooting : SoldierShooting
{
    [SerializeField] private BulletPool _bulletPool;

    public override void Shoot()
    {
        if (ShootTimer >= ShootRate)
        {
            if (_bulletPool.TryGetObject(out GameObject bullet))
            {
                bullet.transform.SetPositionAndRotation(ShootPoint.transform.position, ShootPoint.transform.rotation);
                bullet.transform.RotateAround(bullet.transform.position, bullet.transform.forward, Random.Range(-ShotSpreadAngle, ShotSpreadAngle));

                bullet.SetActive(true);
            }

            ShootTimer = 0;
        }
    }
}