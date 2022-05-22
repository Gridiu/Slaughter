using UnityEngine;

[RequireComponent(typeof(EnemyShooting))]
[RequireComponent(typeof(EnemyMovement))]
public class AttackState : State
{
    private EnemyShooting _enemyShooting;
    private EnemyMovement _enemyMovement;

    private void Start()
    {
        _enemyShooting = GetComponent<EnemyShooting>();
        _enemyMovement = GetComponent<EnemyMovement>();
    }

    private void Update()
    {
        _enemyMovement.Look(Target.transform.position);

        _enemyShooting.Shoot();
    }
}