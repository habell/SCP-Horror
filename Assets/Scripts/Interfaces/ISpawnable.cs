using UnityEngine;

namespace DefaultNamespace.Interfaces
{
    public interface ISpawnable
    {
        GameObject Spawn(Transform pos, SpawnManagerPreset obj);
    }
}