using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingSpikes : Spikes
{
    [SerializeField] private Vector2 _targetPosition;
    [SerializeField] private int _movingTime;

    private void Start()
    {
        transform.DOMove(_targetPosition, _movingTime).SetLoops(-1, LoopType.Yoyo);
    }
}
