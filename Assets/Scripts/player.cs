using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class player : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private HealthBar _bar;

    private int _currentHealth;

    private void Awake()
    {
        _currentHealth = _maxHealth;
        _bar.SetMaxValue(_currentHealth);
    }
}
