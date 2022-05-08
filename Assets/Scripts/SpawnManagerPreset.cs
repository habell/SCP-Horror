using System;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnManagerPreset", menuName = "ScriptableObject/SpawnManagerPreset")]
public class SpawnManagerPreset : ScriptableObject
{
    [SerializeField]
    private SpawnableTypes _type;
    
    [SerializeField]
    private GameObject _prefab;
    
    [SerializeField]
    private List<AttributeData> _attributes;

    public SpawnableTypes Type => _type;
    
    public GameObject Prefab => _prefab;

    public List<AttributeData> Attributes => _attributes;
}