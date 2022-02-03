using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinDisplay : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _currentCoins;

    private void OnCoinChanged(int value)
    {
        _currentCoins.text = value.ToString();
    }

    private void OnEnable()
    {
        _player.CoinChanged += OnCoinChanged;
    }

    private void OnDisable()
    {
        _player.CoinChanged -= OnCoinChanged;
    }

}
