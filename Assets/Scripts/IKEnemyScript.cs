using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class IKEnemyScript : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        var animationClipInfo = _animator.GetCurrentAnimatorClipInfo(0);
        if (animationClipInfo.Length > 0)
            print(animationClipInfo[0].clip);
        else
            _animator.enabled = false;
    }
}