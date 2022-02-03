using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallTrigger : MonoBehaviour
{
    [SerializeField] private Vector2 _restartPosition;
    [SerializeField] private int _fallDamage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Player player))
        {
            player.transform.position = _restartPosition;
            player.TakeDamage(_fallDamage);
        }
    }
}
