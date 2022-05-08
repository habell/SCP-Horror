using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    private GameObject _playerPrefab;

    [SerializeField]
    private GameObject _player;

    public GameObject Player => _player;

    public static Game Instance { get; private set; }

    private void Start()
    {
        Instance = this;
    }
}