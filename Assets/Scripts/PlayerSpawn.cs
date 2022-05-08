using System.Collections;
using System.Collections.Generic;
using DefaultNamespace.Interfaces;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour, IFactory
{
    [SerializeField]
    private SpawnManagerPreset _playerPreset;
    
    private Game _game;
    private void Awake()
    {
        _game = Game.Instance;
        _game.CreatePlayer(Create());
    }
    
    public GameObject Create()
    {
        var player = Instantiate(_game.PlayerPrefab);
        player.GetComponent<ISpawnable>().Spawn(_playerPreset);
        return player;
    }
}
