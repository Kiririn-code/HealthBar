using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int MaxHealth;

    private int _currentHealth;

    public int CurrecntHealth { get { return _currentHealth; } private set { _currentHealth = value; } }

    private void Awake()
    {
        CurrecntHealth = MaxHealth;
    }

    public void GetDamage(int damage)
    {
        CurrecntHealth -= damage;
    }

    public void GetHealth(int health)
    {
        CurrecntHealth += health;
    }
}
