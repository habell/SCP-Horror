using System.Collections;
using System.Collections.Generic;
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
            _enemyList.Add(_enemyFactory.Create());
        }

        _timer -= Time.fixedDeltaTime;
    }
}
