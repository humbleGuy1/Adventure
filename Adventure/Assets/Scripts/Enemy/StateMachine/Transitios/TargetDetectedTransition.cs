using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDetectedTransition : Transition
{
    [SerializeField] private TargetDetection _fieldOFView;

    private void Update()
    {
        if (_fieldOFView.IsDetected)
        {
            NeedTransit = true;
        }
    }
}
