using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Gradient _gradient;
    [SerializeField] private Image _image;
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;

    private float _stepSize = 0.1f;

    public void Start()
    {
        _slider.maxValue = _player.CurrecntHealth;
        _slider.value = _slider.maxValue;
    }

    public void Update()
    {
        _slider.value = Mathf.Lerp(_slider.value, (float)_player.CurrecntHealth, _stepSize);
        _image.color = _gradient.Evaluate(_slider.normalizedValue);
    }
}
