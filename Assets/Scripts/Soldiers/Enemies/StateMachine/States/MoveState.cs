using UnityEngine;

[RequireComponent(typeof(EnemyMovement))]
public class MoveState : State
{
    private EnemyMovement _enemyMovement;

    private void OnEnable() => _enemyMovement = GetComponent<EnemyMovement>();

    private void Update()
    {
        if (Target != null)
        {
            _enemyMovement.Look(Target.transform.position);

            _enemyMovement.Move(Target.transform.position);
        }
    }
}