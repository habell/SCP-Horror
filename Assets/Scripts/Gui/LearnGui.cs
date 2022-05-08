using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class LearnGui : MonoBehaviour
{
    private Health _health;

    private bool _playerIsCreated;

    private void FixedUpdate()
    {
        if (!_playerIsCreated)
            if (Game.Instance.Player)
            {
                _health = Game.Instance.Player.GetComponent<Health>();
                _playerIsCreated = true;
            }
    }

    void OnGUI()
    {
        if (_playerIsCreated)
            GUI.Box(new Rect(10, 10, 200, 140),
                _health.HealthValue.ToString());
    }
}