using UnityEngine;

public abstract class Soldier : MonoBehaviour
{
    [SerializeField] protected float MaxHealth;

    protected float СurrentHealth;

    protected virtual void Start() => СurrentHealth = MaxHealth;

    public virtual void TakeDamage(float damage) => СurrentHealth -= damage;
}