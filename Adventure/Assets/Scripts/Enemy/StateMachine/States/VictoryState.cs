using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class VictoryState : State
{
    private Animator _aimator;
    private const string Victory = "Victory";

    private void Start()
    {
        _aimator = GetComponent<Animator>();
        _aimator.Play(Victory);
    }
}
