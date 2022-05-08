using System;
using DefaultNamespace;
using DefaultNamespace.Interfaces;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class Player : MonoBehaviour, ISpawnable, IUnit
{
    private Health _health;

    public Health Health => _health;

    private IWeapon _usingWeapon;
    //TODO: Make Inventory;

    public void SetWeapon(IWeapon weapon)
    {
        _usingWeapon = weapon;
    }

    public void Spawn(SpawnManagerPreset objPreset)
    {
        var attributeValue = float.Parse(objPreset.GetAttributeData(Attributes.MaxHealth).AttributeValue);
        if (!_health) _health = GetComponent<Health>();
        _health.SetHealth(attributeValue);
    }


    public void Attack()
    {
        throw new System.NotImplementedException();
    }
}