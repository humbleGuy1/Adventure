using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private Animator _dialogueBoxAnimator;
    [SerializeField] private Animator _startBoxAnimator;
    [SerializeField] private TMP_Text _dialogueText;
    [SerializeField] private TMP_Text _name;

    private Coroutine _textJob;
    private Queue<string> _sentences;
    private const string IsStartBoxOpen = "isStartBoxOpen";
    private const string IsBoxOpen = "isBoxOpen";


    private void Start()
    {
        _sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        _dialogueBoxAnimator.SetBool(IsBoxOpen, true);
        _startBoxAnimator.SetBool(IsStartBoxOpen, false);

        _name.text = dialogue.Name;
        _sentences.Clear();

        foreach(string sentence in dialogue.Sentences)
        {
            _sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void EndDialogue()
    {
        _dialogueBoxAnimator.SetBool(IsBoxOpen, false);
    }

    public void DisplayNextSentence()
    {
        if(_sentences.Count == 0)
        {
            EndDialogue();
        }

        string sentence = _sentences.Dequeue();

        if (_textJob != null)
            StopCoroutine(_textJob);

        _textJob = StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        _dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            _dialogueText.text += letter;
            yield return null;
        }
    }





}
