using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource _levelMusic;
    [SerializeField] private AudioSource _bossMusic;
    [SerializeField] private Canvas _bossHealthbar;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Player player))
        {
           _levelMusic.Stop();
           _bossMusic.Play();
           _bossHealthbar.gameObject.SetActive(true);
           gameObject.SetActive(false);
        }
    }
}
