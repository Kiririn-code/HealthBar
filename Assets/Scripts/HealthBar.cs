using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] Gradient _gradient;
    [SerializeField] Image _image;
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.value = _slider.maxValue;
       _image.color= _gradient.Evaluate(1f);

    }

    public void GetDamage()
    {
        _slider.value -= 10;
        _image.color = _gradient.Evaluate(_slider.normalizedValue);
        
    }
    public void GetHealth()
    {
        _slider.value += 10;
        _image.color = _gradient.Evaluate(_slider.normalizedValue);
    }
}
