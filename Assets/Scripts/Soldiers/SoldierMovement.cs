using UnityEngine;

public abstract class SoldierMovement : MonoBehaviour
{
    [SerializeField] protected float Speed;

    public virtual void Look(Vector3 targetPosition)
    {
        Vector2 lookDirection = new Vector2(targetPosition.x - transform.position.x, targetPosition.y - transform.position.y);
        transform.up = lookDirection;
    }
}