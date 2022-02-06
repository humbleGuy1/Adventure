using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(AudioSource))]

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;

    public event UnityAction<float> HealthChanged;
    public event UnityAction<int> CoinChanged;
   
    private int _coins;
    private int _minHealth;
    private int _maxHealth;
    private Animator _animator;
    private const string Death = "Death";
    private const string Hurt = "Hurt";
    private AudioSource _audioSource;
    private bool _hasKey;

    public bool HasKey => _hasKey;
    public int Coins => _coins;

    private void Start()
    {
        _minHealth = 0;
        _maxHealth = 100;
        _animator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
        _hasKey = false;
    }

    public void TakeCoin(int value)
    {
        _coins += value;
        CoinChanged?.Invoke(_coins);
        _audioSource.Play();
    }

    public void TakeDamage(int damage)
    {
        _health = Mathf.Clamp(_health - damage, _minHealth, _maxHealth);
        HealthChanged?.Invoke(_health);

        if (_health > 0)
        _animator.Play(Hurt);

        if(_health <= 0)
            StartCoroutine(Die());
    }

    public void Heal(int value)
    {
        _health = Mathf.Clamp(_health + value, _minHealth, _maxHealth);
        HealthChanged?.Invoke(_health);
    }

    public void BuyKey(int price)
    {
        if(_coins >= price)
        {
            _coins -= price;
            CoinChanged?.Invoke(_coins);
            _hasKey = true;
        }
    }

    private IEnumerator Die()
    {
        while (true)
        {
            _animator.Play(Death);

            yield return new WaitForSeconds(1f);

            Destroy(gameObject);
        }
    }
}
