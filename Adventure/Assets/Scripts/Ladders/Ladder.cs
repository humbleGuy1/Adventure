using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    [SerializeField] private int _climbSpeed;

    private void OnTriggerStay2D(Collider2D collision)
    {
      if(collision.TryGetComponent(out Player player))
        {
            Rigidbody2D playerRigidBody = player.GetComponent<Rigidbody2D>();
            playerRigidBody.gravityScale = 0;

            if (Input.GetKey(KeyCode.W))
            {
                player.transform.Translate(Vector2.up * _climbSpeed * Time.deltaTime);    
            }

            if (Input.GetKey(KeyCode.S))
            {
                player.transform.Translate(Vector2.down * _climbSpeed * Time.deltaTime);
            }
        }  
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            Rigidbody2D playerRigidBody = player.GetComponent<Rigidbody2D>();
            playerRigidBody.gravityScale = 1;
        }
    }
}
