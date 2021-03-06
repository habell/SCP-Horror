using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace.Interfaces;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyFactory : MonoBehaviour, IFactory
{
    private SpawnManagerPreset _creatableObject;
    private Transform _spawnPosition;

    public void InitializeFactory(SpawnManagerPreset creatableObject, Transform spawnPosition)
    {
        _creatableObject = creatableObject;
        _spawnPosition = spawnPosition;
    }

    public GameObject Create()
    {
        var spawnedEnemy = Instantiate(_creatableObject.Prefab, _spawnPosition.position, _spawnPosition.rotation,
            transform);
        spawnedEnemy.GetComponent<ISpawnable>().Spawn(_creatableObject);
        return spawnedEnemy;
    }
}