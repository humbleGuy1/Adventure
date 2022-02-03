using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tosser : MonoBehaviour
{
    [SerializeField] private float _tossForce;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Player player))
        {
            Rigidbody2D RigidBody = player.GetComponent<Rigidbody2D>();
            RigidBody.AddForce(Vector2.up * _tossForce, ForceMode2D.Impulse);
        }
    }
}
