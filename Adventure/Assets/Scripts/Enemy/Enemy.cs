using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(EnemyStateMachine))]

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private Player _target;

    public int Health => _health;
    public Player Target => _target;

    private const string Death = "Death";
    private const string Hurt = "Hurt";
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    private EnemyStateMachine _enemyStateMachine;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _enemyStateMachine = GetComponent<EnemyStateMachine>();
    }

    private void Update()
    {
        if(_target != null)
        {
            if (_target.transform.position.x > transform.position.x)
                _spriteRenderer.flipX = false;
            else
                _spriteRenderer.flipX = true;
        }
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        _animator.Play(Hurt);

            if (_health <= 0)
            {
                StartCoroutine(Die());
            }
    }

    private IEnumerator Die()
    {
        while (true)
        {
            _enemyStateMachine.CurrentState.Exit();
            _animator.Play(Death);

            yield return new WaitForSeconds(1.5f);

            Destroy(gameObject);
        }
    }
}
