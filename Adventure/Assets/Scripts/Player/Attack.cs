using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Attack : MonoBehaviour
{

    private Animator _animator;
    private const string MeleeAttack = "MeleeAttack";

    void Start()
    {
        _animator = GetComponent<Animator>();    
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _animator.SetTrigger(MeleeAttack);
        }        
    }
}
