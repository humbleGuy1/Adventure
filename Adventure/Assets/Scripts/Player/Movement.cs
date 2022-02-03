using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Animator _animator;
    private const string Idle = "Idle";
    private const string Walk = "Walk";

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
    }

    private bool Move()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            Vector3 scale = transform.localScale;

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * _speed * Time.deltaTime);
                scale.x = -1;
                transform.localScale = scale;
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * _speed * Time.deltaTime);
                scale.x = 1;
                transform.localScale = scale;
            }

            _animator.SetTrigger(Walk);

            return true;
        }
        else
        {
            _animator.SetTrigger(Idle);
            return false;
        }
    }
}
