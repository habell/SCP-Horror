using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace.Interfaces;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour, IFactory
{
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
            Create();
        }

        _timer -= Time.fixedDeltaTime;
    }

    public GameObject Create()
    {
        var random = Random.Range(0, _spawnPositions.Length);
        Instantiate(_manager.Prefab, _spawnPositions[random].position, _spawnPositions[random].rotation);
        var spawnedEnemy = _manager.Prefab.GetComponent<ISpawnable>().Spawn(_manager);
        _enemyList.Add(spawnedEnemy);
        return spawnedEnemy;
    }
}