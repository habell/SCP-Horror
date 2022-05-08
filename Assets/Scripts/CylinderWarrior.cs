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

        public void Spawn(SpawnManagerPreset preset)
        {
            var attributeValue = float.Parse(preset.GetAttributeData(Attributes.MaxHealth).AttributeValue);
            if(!_health) _health = GetComponent<Health>();
            _health.SetHealth(attributeValue);
        }
    }
}