using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TosserActivator : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Tosser _tosser;

    private void OnHealthChanged(int health)
    {
        if (health <= 0)
            _tosser.gameObject.SetActive(true);
    }

    private void OnEnable()
    {
        _enemy.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _enemy.HealthChanged -= OnHealthChanged;
    }
}
