using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class IdleState : State
{
    private Animator _animator;
    private const string Idle = "Idle";

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.Play(Idle);
    }
}
