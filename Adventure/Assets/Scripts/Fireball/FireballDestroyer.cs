using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Fireball fireball))
        {
            Destroy(fireball.gameObject);
        }
    }
}
