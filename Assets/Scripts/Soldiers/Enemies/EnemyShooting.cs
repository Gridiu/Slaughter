using UnityEngine;

public class EnemyShooting : SoldierShooting
{
    [SerializeField] private Bullet _bullet;

    public override void Shoot()
    {
        if (ShootTimer >= ShootRate)
        {
            GameObject bullet = Instantiate(_bullet.gameObject, ShootPoint.transform.position, ShootPoint.transform.rotation);
            bullet.transform.RotateAround(bullet.transform.position, bullet.transform.forward, Random.Range(-ShotSpreadAngle, ShotSpreadAngle));

            ShootTimer = 0;
        }
    }
}