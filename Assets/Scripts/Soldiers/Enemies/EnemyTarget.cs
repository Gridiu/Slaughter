using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    private Player _target;

    public Player Target => _target;

    private void OnDisable() => _target.Died -= Reset;

    public void SetTarget(Player target)
    {
        _target = target;

        _target.Died += Reset;
    }

    private void Reset() => gameObject.SetActive(false);
}