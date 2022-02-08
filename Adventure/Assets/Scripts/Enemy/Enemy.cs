using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(EnemyStateMachine))]

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private Player _target;

    public Player Target => _target;

    public event UnityAction<int> HealthChanged;

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
        _spriteRenderer.flipX = true;

        if(_target != null)
        {
            bool isPlayerBehind = _target.transform.position.x > transform.position.x;

            if (isPlayerBehind)
                _spriteRenderer.flipX = false;
        }
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        _animator.Play(Hurt);
        HealthChanged?.Invoke(_health);

        if (_health <= 0)
            StartCoroutine(Die());
    }

    private IEnumerator Die()
    {
        while (true)
        {
            var waitForSeconds = new WaitForSeconds(1.5f);
            _enemyStateMachine.CurrentState.Exit();
            _animator.Play(Death);

            yield return waitForSeconds;

            Destroy(gameObject);
        }
    }
}
