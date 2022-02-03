using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRunAwayTransition : Transition
{

    [SerializeField] private float _transitionRange;

    private void Update()
    {
        if(Target != null)
        {
            if (Vector2.Distance(transform.position, Target.transform.position) > _transitionRange)
                NeedTransit = true;
        }
    }
}
