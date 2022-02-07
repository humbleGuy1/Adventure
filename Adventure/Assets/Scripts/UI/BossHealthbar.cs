using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthbar : MonoBehaviour
{
    [SerializeField] private Enemy _boss;
    [SerializeField] private Slider _healthbar;

    private void OnHealthChanged(int value)
    {
        _healthbar.value = value;
    }

    private void OnEnable()
    {
        _boss.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _boss.HealthChanged -= OnHealthChanged;
    }
}
