using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellKeyButton : MonoBehaviour
{
    [SerializeField] private Player _player;

    private int _price;

    private void Start()
    {
        _price = 100;
    }

    public void OnButtonClick()
    {
       
        _player.BuyKey(_price);
    }
}
