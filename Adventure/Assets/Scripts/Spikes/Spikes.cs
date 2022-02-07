using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField] private int _damage;

    private float _elapsedTime;

    private void Start()
    {
        _elapsedTime = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Player player))
        {
            player.TakeDamage(_damage);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            _elapsedTime += Time.deltaTime;
            
            if(_elapsedTime > 1f)
            {
                player.TakeDamage(_damage);
                _elapsedTime = 0;
            }
        }
    }

}
