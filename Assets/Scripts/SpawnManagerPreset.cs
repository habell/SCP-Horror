
using System.Collections.Generic;
using Interface;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnManagerPreset", menuName = "ScriptableObject/SpawnManagerPreset")]
public class SpawnManagerPreset : ScriptableObject
{
    [SerializeField] 
    private GameObject _parent;

    [SerializeField] 
    private List<GameObject> _objects;
}
