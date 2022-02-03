using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenBoxTrigger : MonoBehaviour
{
    [SerializeField] private Image _image;

    private Animator _animator;
    private const string IsBoxOpen = "isBoxOpen";

    private void Start()
    {
        _animator = _image.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _animator.SetBool(IsBoxOpen, true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _animator.SetBool(IsBoxOpen, false);
    }
}
