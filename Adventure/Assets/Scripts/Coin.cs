using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _reward;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Player player))
        {
            _player.TakeCoin(_reward);
            Destroy(gameObject);
        }
    }
}
