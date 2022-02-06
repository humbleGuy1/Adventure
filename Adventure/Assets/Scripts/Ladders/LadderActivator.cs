using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LadderActivator : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Ladder _ladder;
    [SerializeField] private float _speed;
    [SerializeField] private float _targetY;

    private void OnHealthChanged(int health)
    {
        if (health <= 0)
            StartCoroutine(ThrowDownLadder());
    }

    private void OnEnable()
    {
        _enemy.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _enemy.HealthChanged -= OnHealthChanged;
    }

    private IEnumerator ThrowDownLadder()
    {
        while (true)
        {
            _ladder.transform.position = new Vector2(_ladder.transform.position.x,
                        Mathf.MoveTowards(_ladder.transform.position.y, _targetY, _speed));

            yield return null;
        }
    }
}
