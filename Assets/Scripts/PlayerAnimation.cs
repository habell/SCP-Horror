using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField]
    private string _speedAnimation;
    [SerializeField]
    private string _jumpAnimation;

    private int _animSpeedHash;

    private int _animJumpHash;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _animSpeedHash = Animator.StringToHash(_speedAnimation);
        _animJumpHash = Animator.StringToHash(_jumpAnimation);
    }

    public void ChangeSpeed(float value)
    {
        _animator.SetFloat(_animSpeedHash, value);
    }    
    public void ChangeJump(float value)
    {
        _animator.SetFloat(_animJumpHash, value);
    }
}
