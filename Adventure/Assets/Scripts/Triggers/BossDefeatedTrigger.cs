using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDefeatedTrigger : MonoBehaviour
{
    [SerializeField] private Enemy _boss;
    [SerializeField] private Canvas _bossHealthbar;
    [SerializeField] private AudioSource _bossMusic;

    private float _speed;

    private void Start()
    {
        _speed = 0.5f;
    }

    private void OnHealthChanged(int health)
    {
        if (health <= 0)
        {
            _bossHealthbar.gameObject.SetActive(false);
            StartCoroutine(DecreaseVolume());
        }
    }

    private void OnEnable()
    {
        _boss.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _boss.HealthChanged -= OnHealthChanged;
    }

    private IEnumerator DecreaseVolume()
    {
        while (true)
        {
            _bossMusic.volume = Mathf.MoveTowards(_bossMusic.volume, 0, _speed * Time.deltaTime);

            yield return null;
        }
    }


}
