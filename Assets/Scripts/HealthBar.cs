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

    private Coroutine _StartChangeValue;
    private float _stepSize = 2f;

    private void OnEnable()
    {
        _player.HealthChanged += RunCoroutine;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= RunCoroutine;
    }

    public void Start()
    {
        _slider.maxValue = _player.MaxHelath;
        _slider.value = _slider.maxValue;
        _image.color = _gradient.Evaluate(_slider.normalizedValue);
    }

    private void RunCoroutine(int health)
    {
        if (_StartChangeValue != null)
            StopCoroutine(_StartChangeValue);

        _StartChangeValue = StartCoroutine(ChangeValue(health));
    }

    private IEnumerator ChangeValue(int health)
    {
        var UpdateFrameTime = new WaitForEndOfFrame();

        while (_slider.value != health)
        {
            _slider.value = Mathf.Lerp(_slider.value, health, _stepSize * Time.deltaTime);
            _image.color = _gradient.Evaluate(_slider.normalizedValue);
            yield return UpdateFrameTime;
        }
    }
}
