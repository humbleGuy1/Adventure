using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class MoveState : State
{
    [SerializeField] private float _speed;

    private Animator _animator;
    private const string Walk = "Walk";

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.Play(Walk);
    }
    private void OnEnable()
    {
        _animator.Play(Walk);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(Target.transform.position.x, transform.position.y),
            _speed * Time.deltaTime);
    }
}
