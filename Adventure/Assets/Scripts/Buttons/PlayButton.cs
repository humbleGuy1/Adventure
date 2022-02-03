using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class PlayButton : MonoBehaviour
{
    public void OnButtonClick()
    {
        Level.Load();
    }
}
