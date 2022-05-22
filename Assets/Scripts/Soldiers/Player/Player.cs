using UnityEngine.Events;

public class Player : Soldier
{
    public UnityAction<float, float> HealthChanged;
    public UnityAction Died;

    private void OnEnable() => Game.Restarted += Reset;

    protected override void Start()
    {
        base.Start();

        HealthChanged?.Invoke(СurrentHealth, MaxHealth);
    }

    private void OnDisable() => Game.Restarted -= Reset;

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);

        HealthChanged?.Invoke(СurrentHealth, MaxHealth);

        if (СurrentHealth <= 0)
        {
            СurrentHealth = 0;

            Died?.Invoke();
        }
    }

    private void Reset()
    {
        СurrentHealth = MaxHealth;

        HealthChanged?.Invoke(СurrentHealth, MaxHealth);
    }
}