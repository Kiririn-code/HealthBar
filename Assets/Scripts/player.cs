using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    private int _currentHealth;

    public event UnityAction<int> HealthChanged;


    public int CurrecntHealth { get { return _currentHealth; } private set { _currentHealth = value; } }
    public int MaxHelath { get { return _maxHealth; }}

    private void Awake()
    {
        CurrecntHealth = _maxHealth;
    }

    public void GetDamage(int damage)
    {
        CurrecntHealth -= damage;
        HealthChanged?.Invoke(CurrecntHealth);
    }

    public void GetHealth(int health)
    {
        CurrecntHealth += health;
        HealthChanged?.Invoke(CurrecntHealth);
    }
}
