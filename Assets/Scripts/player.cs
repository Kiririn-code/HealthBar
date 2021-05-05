using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth;

    private int _currentHealth;

    private void Awake()
    {
        _currentHealth = _maxHealth;
    }

    public void GetDamage(int damage)
    {
        _currentHealth -= damage;
    }

    public void GetHealth(int health)
    {
        _currentHealth += health;
    }
    public int GetMaxHealth()
    {
        return _maxHealth;
    }
    public int GetHealth() => _currentHealth;
}
