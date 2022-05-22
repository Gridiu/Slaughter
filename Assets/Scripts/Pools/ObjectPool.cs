using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectPoolItem
{
    public GameObject ObjectToPool;
    public int Quantity;
}

public abstract class ObjectPool : MonoBehaviour
{
    [SerializeField] protected GameObject Container;
    [SerializeField] protected List<ObjectPoolItem> ItemsToPool;

    protected List<GameObject> Pool;

    protected virtual void Start()
    {
        Pool = new List<GameObject>();

        foreach (ObjectPoolItem item in ItemsToPool)
        {
            for (int i = 0; i < item.Quantity; i++)
            {
                var itemInPool = Instantiate(item.ObjectToPool, Container.transform);
                itemInPool.SetActive(false);

                Pool.Add(itemInPool);
            }
        }
    }

    public abstract bool TryGetObject(out GameObject result);
}