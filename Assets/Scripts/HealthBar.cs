using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Gradient _gradient;
    [SerializeField] private Image _image;

    private Slider _slider;

    private void Awake()
    {
       _slider = GetComponent<Slider>();
       _image.color= _gradient.Evaluate(1f);
    }

    public void SetMaxValue(int maxValue)
    {
        _slider.maxValue = maxValue;
        _slider.value = _slider.maxValue;
    }

    public void GetDamage(int value)
    {
        _slider.value -= value;
        _image.color = _gradient.Evaluate(_slider.normalizedValue);
        
    }
    public void GetHealth(int value)
    {
        _slider.value += value;
        _image.color = _gradient.Evaluate(_slider.normalizedValue);
    }
}
