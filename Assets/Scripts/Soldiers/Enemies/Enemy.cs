using UnityEngine.Events;

public class Enemy : Soldier
{
    public static UnityAction Died;

    private void OnEnable() => СurrentHealth = MaxHealth;

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);

        if (СurrentHealth <= 0)
        {
            СurrentHealth = 0;

            Died?.Invoke();

            gameObject.SetActive(false);
        }
    }
}