using UnityEngine;

public abstract class SoldierShooting : MonoBehaviour
{
    [SerializeField] protected GameObject ShootPoint;
    [SerializeField] protected float ShootRate;

    protected const float ShotSpreadAngle = 3f;

    protected float ShootTimer;

    protected void Update() => ShootTimer += Time.deltaTime;

    public abstract void Shoot();
}