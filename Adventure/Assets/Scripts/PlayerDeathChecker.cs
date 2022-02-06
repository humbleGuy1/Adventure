using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathChecker : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Canvas _gameOverScreen;

    private void OnHealthChanged(float value)
    {
        if(value <= 0)
        {
            _gameOverScreen.gameObject.SetActive(true);
        }
    }

    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
    }
}
