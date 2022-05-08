using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace.Interfaces;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private SpawnManagerPreset _manager;

    [SerializeField]
    private Transform[] _spawnPositions;

    [SerializeField]
    private List<GameObject> _enemyList;


    private float _timer;
    private void FixedUpdate()
    {
        if (_timer <= 0)
        {
            _timer += 10;
            var random = Random.Range(0, _spawnPositions.Length);
            Spawn(random);
        }

        _timer -= Time.fixedDeltaTime;
    }

    private void Spawn(int id)
    {
        _enemyList.Add(_manager.Prefab.GetComponent<ISpawnable>().Spawn(_spawnPositions[id], _manager.Prefab));
    }
}
