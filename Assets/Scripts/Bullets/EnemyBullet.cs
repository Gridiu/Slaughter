using UnityEngine;

public class EnemyBullet : Bullet
{
    private const float MaxLifeTime = 5f;

    private void Start() => Destroy(gameObject, MaxLifeTime);

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);

        Destroy(gameObject);
    }
}