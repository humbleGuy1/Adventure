using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimator : MonoBehaviour
{
    [SerializeField] private Animator _startBoxAnimator;
    [SerializeField] private DialogueManager _dialoguManager;

    private const string IsStartBoxOpen = "isStartBoxOpen";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _startBoxAnimator.SetBool(IsStartBoxOpen, true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _startBoxAnimator.SetBool(IsStartBoxOpen, false);
        _dialoguManager.EndDialogue();
    }
}
