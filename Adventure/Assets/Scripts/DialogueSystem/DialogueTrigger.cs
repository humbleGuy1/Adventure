using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] private Dialogue _dialogue;
    [SerializeField] private DialogueManager _dialogueManager;

    public void ActivateDialogue()
    {
        _dialogueManager.StartDialogue(_dialogue);
    }
}
