using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Image _background;
    [SerializeField] private Image _value;
    

    public void SetProgress(float progress)
    {
        progress = Mathf.Clamp01(progress);
        var backgroundSize = _background.rectTransform.sizeDelta.x;
        var valueSize = progress * backgroundSize;
        _value.rectTransform.sizeDelta = new Vector2(valueSize, _background.rectTransform.sizeDelta.y); 
    }
}