using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    private GameObject _playerPrefab;

    private GameObject _player;

    public GameObject PlayerPrefab => _playerPrefab;
    public GameObject Player => _player;

    public static Game Instance { get; private set; }

    public void CreatePlayer(GameObject player)
    {
        if (!_player)
        {
            _player = player;
        }
    }

    private void Awake()
    {
        Instance = this;
    }
}