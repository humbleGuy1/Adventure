using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void OnPlayButtonClick()
    {
        _canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnExitButtonClick()
    {
        Application.Quit();
    }
}
