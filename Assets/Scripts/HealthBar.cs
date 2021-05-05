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

    private void Awake()
    {
        _slider.maxValue = _player.GetMaxHealth();
       _slider = GetComponent<Slider>();
       _image.color= _gradient.Evaluate(1f);
    }

    public void Start()
    {
        _slider.maxValue = _player.GetHealth();
        _slider.value = _slider.maxValue;
    }

    public void Update()
    {
        _slider.value = _player.GetHealth();
        _image.color = _gradient.Evaluate(_slider.normalizedValue);
        
    }
}
