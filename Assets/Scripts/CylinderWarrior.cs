using DefaultNamespace.Interfaces;
using UnityEngine;

namespace DefaultNamespace
{
    public class CylinderWarrior : MonoBehaviour, IEnemy
    {
        public GameObject Spawn(Transform spawnPosition, GameObject obj)
        {
            return Instantiate(obj, spawnPosition.position, spawnPosition.rotation);
        }
    }
}