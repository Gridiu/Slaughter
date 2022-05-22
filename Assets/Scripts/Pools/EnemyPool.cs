using System.Linq;
using UnityEngine;

public class EnemyPool : ObjectPool
{
    public override bool TryGetObject(out GameObject result)
    {
        var activeObjects = Pool.Where(p => p.activeSelf == false).ToList();

        if (activeObjects.Count > 0)
            result = activeObjects.ElementAt(Random.Range(0, activeObjects.Count));
        else
            result = null;

        return result != null;
    }
}