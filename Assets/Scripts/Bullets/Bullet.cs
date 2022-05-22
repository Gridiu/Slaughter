using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] protected float Damage;
    [SerializeField] protected float Speed;

    protected void OnEnable() => Game.Restarted += Reset;

    protected void Update() => transform.Translate(Speed * Time.deltaTime * Vector2.up);

    protected void OnDisable() => Game.Restarted -= Reset;

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        collision.TryGetComponent<Soldier>(out Soldier soldier);

        soldier.TakeDamage(Damage);
    }

    protected void Reset() => gameObject.SetActive(false);
}