using System;
using DefaultNamespace.Interfaces;
using UnityEngine;

namespace DefaultNamespace
{
    [RequireComponent(typeof(Health))]
    public class CylinderWarrior : MonoBehaviour, IEnemy
    {
        public GameObject Spawn(Transform spawnPosition, SpawnManagerPreset obj)
        {
            var spawnedObject = Instantiate(obj.Prefab, spawnPosition.position, spawnPosition.rotation);
            foreach (var attributeData in obj.Attributes)
            {
                if (attributeData.AttributeName == Attributes.MaxHealth)
                {
                    spawnedObject.GetComponent<Health>().SetHealth(float.Parse(attributeData.AttributeValue));
                }
            }
            return spawnedObject;
        }
    }
}