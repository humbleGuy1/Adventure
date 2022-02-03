using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LadderActivator : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Ladder _ladder;
    [SerializeField] private float _speed;
    [SerializeField] private float _targetY;

    private void Update()
    {
        if (_enemy.Health <= 0)
        {
            _ladder.transform.position = new Vector2(_ladder.transform.position.x, 
                Mathf.MoveTowards(_ladder.transform.position.y, _targetY, _speed));
        }
    }
}
