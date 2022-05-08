using System;
using DefaultNamespace;
using DefaultNamespace.Interfaces;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class Player : MonoBehaviour, ISpawnable, IUnit
{
    [SerializeField]
    private Health _health;

    public Health Health => _health;

    private IWeapon _usingWeapon;
    //TODO: Make Inventory;

    public void SetWeapon(IWeapon weapon)
    {
        _usingWeapon = weapon;
    }

    private void Awake()
    {
        if(!_health) _health = GetComponent<Health>();
    }

    public GameObject Spawn(SpawnManagerPreset objPreset)
    {
        var attributeValue = float.Parse(objPreset.GetAttributeData(Attributes.MaxHealth).AttributeValue);
        Health.SetHealth(attributeValue);
        
        return gameObject;
    }


    public void Attack()
    {
        throw new System.NotImplementedException();
    }
}