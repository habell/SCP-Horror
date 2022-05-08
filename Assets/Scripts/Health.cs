using System;
using System.Collections.Generic;
using DefaultNamespace.Interfaces;
using UnityEngine;

namespace DefaultNamespace
{
    public class Health : MonoBehaviour
    {
        private float _healthValue;
        public float HealthValue => _healthValue;

        public void SetHealth(float value)
        {
            if (_healthValue + value > 0)
            {
                _healthValue += value;
            }
            else
            {
                Death();
            }
        }

        private void Death()
        {
            if (TryGetComponent(out IDeath obj))
            {
                obj.Death();
            }
            else
            {
                print("Oh no, i'm death!");
                Destroy(gameObject);
            }
        }
    }
}