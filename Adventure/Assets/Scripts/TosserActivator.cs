using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TosserActivator : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Tosser _tosser;

    private void Update()
    {
        if (_enemy.Health <= 0)
            _tosser.gameObject.SetActive(true);
    }
}
