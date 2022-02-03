using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _slider;
    [SerializeField] private float _speed;

    private Coroutine _valueChangeJob;

    private void OnHealthChanged(float value)
    {
        if (_valueChangeJob != null)
            StopCoroutine(_valueChangeJob);

       _valueChangeJob = StartCoroutine(ChangeValue(value));
    }

    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
    }

    private IEnumerator ChangeValue(float targetValue)
    {
        while (!Mathf.Approximately(_slider.value, targetValue))
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetValue, _speed * Time.deltaTime);
            yield return null;
        }
    }
}
