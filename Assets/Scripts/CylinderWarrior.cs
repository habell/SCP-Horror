using System;
using DefaultNamespace.Interfaces;
using UnityEngine;

namespace DefaultNamespace
{
    [RequireComponent(typeof(Health))]
    public class CylinderWarrior : MonoBehaviour, IEnemy
    {
        private Health _health;
        public Health Health => _health;
        private void Start()
        {
            _health = GetComponent<Health>();
        }

        public GameObject Spawn(SpawnManagerPreset preset)
        {
            var attributeValue = float.Parse(preset.GetAttributeData(Attributes.MaxHealth).AttributeValue);
            Health.SetHealth(attributeValue);

            return gameObject;
        }
    }
}