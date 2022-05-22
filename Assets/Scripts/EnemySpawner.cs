using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyPool _enemyPool;
    [SerializeField] private float _spawnRate;
    [SerializeField] private Player _target;

    private List<Transform> _spawnPoints;
    private float _timer;

    private void Start()
    {
        _spawnPoints = new List<Transform>();

        for (int i = 0; i < transform.childCount; i++)
        {
            _spawnPoints.Add(transform.GetChild(i));
        }

        _timer = _spawnRate;
    }

    private void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            if (_enemyPool.TryGetObject(out GameObject enemy))
            {
                enemy.transform.position = _spawnPoints[Random.Range(0, _spawnPoints.Count)].gameObject.transform.position;
                enemy.SetActive(true);

                enemy.GetComponent<EnemyTarget>().SetTarget(_target);
            }

            _timer = _spawnRate;
        }
    }
}