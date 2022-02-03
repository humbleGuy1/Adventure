using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
    [SerializeField] private RawImage _rawImage;
    [SerializeField] private float _xSpeed;

    private void Update()
    {
        _rawImage.uvRect = new Rect(_rawImage.uvRect.position + new Vector2(_xSpeed, _rawImage.uvRect.position.y)
            * Time.deltaTime, _rawImage.uvRect.size);
    }

}
