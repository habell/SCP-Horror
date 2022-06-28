using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class IKController : MonoBehaviour
{
    [SerializeField]
    private bool _isActiveIK;

    [SerializeField]
    private IKPositionsData[] _animPoints;

    [SerializeField]
    private Transform _lookPosition;
    
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        if (Vector3.Distance(_lookPosition.position, transform.position) < 2)
        {
            _animator.SetLookAtWeight(1);
            _animator.SetLookAtPosition(_lookPosition.position);
        }
        else
            _animator.SetLookAtWeight(0);
        
        if (_isActiveIK)
        {

            foreach (var animData in _animPoints)
            {
                SetWeightIK(animData.BonePositionType, 1);
                SetIKAnimation(animData.BonePositionType, animData.Position);
            }
        }
        else
        {
            foreach (var animData in _animPoints)
            {
                SetWeightIK(animData.BonePositionType, 0);
            }
        }
    }

    private void SetWeightIK(AvatarIKGoal type, float value)
    {
        _animator.SetIKPositionWeight(type, value);
        _animator.SetIKRotationWeight(type, value);
    }

    private void SetIKAnimation(AvatarIKGoal type, Transform transform)
    {
        _animator.SetIKPosition(type, transform.position);
        _animator.SetIKRotation(type, transform.rotation);
    }
    
}
