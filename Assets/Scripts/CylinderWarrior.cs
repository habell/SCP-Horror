using System;
using DefaultNamespace.Interfaces;
using UnityEngine;

namespace DefaultNamespace
{
    [RequireComponent(typeof(Health))]
    public class CylinderWarrior : MonoBehaviour, IEnemy, IDeath
    {
        [SerializeField]
        private Health _health;

        public Health Health => _health;

        public EnemyManager EnemyManager { get; private set; }

        public void SetEnemyManager(EnemyManager enemyManager)
        {
            EnemyManager = enemyManager;
        }

        public void Spawn(SpawnManagerPreset preset)
        {
            var attributeValue = float.Parse(preset.GetAttributeData(Attributes.MaxHealth).AttributeValue);
            if (!_health) _health = gameObject.GetComponent<Health>();
            _health.SetHealth(attributeValue);
        }

        public void Death()
        {
            EnemyManager.RemoveEnemyInEnemyList(gameObject);
            Destroy(gameObject);
        }
    }
}