using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballsTrigger : MonoBehaviour
{
    [SerializeField] private FireballSpawner _fireballSpaawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Player player))
        {
            _fireballSpaawner.gameObject.SetActive(true);
        }

        gameObject.SetActive(false);
    }
}
