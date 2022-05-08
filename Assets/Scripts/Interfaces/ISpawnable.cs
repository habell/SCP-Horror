using UnityEngine;

namespace DefaultNamespace.Interfaces
{
    public interface ISpawnable
    {
        GameObject Spawn(SpawnManagerPreset preset);
    }
}