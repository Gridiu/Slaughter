using UnityEngine;

public class EnemyMovement : SoldierMovement
{
    public void Move(Vector3 targetPosition)
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Speed * Time.deltaTime);
    }
}