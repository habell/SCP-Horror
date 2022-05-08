using System.Collections;
using System.Collections.Generic;
using DefaultNamespace.Interfaces;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    private EnemyFactory _enemyFactory;

    [SerializeField]
    private SpawnManagerPreset _manager;

    [SerializeField]
    private Transform[] _spawnPositions;

    [SerializeField]
    private List<GameObject> _enemyList;

    private float _timer;

    private void Start()
    {
        if (_spawnPositions.Length < 1)
        {
            _spawnPositions[0] = transform;
            Debug.LogError("Spawner not have spawn positions!");
        }
    }

    private void FixedUpdate()
    {
        if (_timer <= 0)
        {
            _timer += 10;
            var random = Random.Range(0, _spawnPositions.Length);

            _enemyFactory.InitializeFactory(_manager, _spawnPositions[random]);
            var enemy = _enemyFactory.Create();

            enemy.GetComponent<IEnemy>().SetEnemyManager(this);

            _enemyList.Add(enemy);
        }

        _timer -= Time.fixedDeltaTime;
    }

    public void RemoveEnemyInEnemyList(GameObject enemy)
    {
        foreach (var _enemy in _enemyList)
        {
            if (_enemy == enemy)
            {
                _enemyList.Remove(_enemy);
                break;
            }
        }
    }
}