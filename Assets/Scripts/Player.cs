using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] public float Health;
    [SerializeField] public float MaxHealth;

    public event UnityAction HealthChanged;
    private float _healthChanging = 10;

    public void Heal()
    {
        Health += _healthChanging;
        HealthChanged?.Invoke();
    }

    public void TakeDamage()
    {
        Health -= _healthChanging;
        HealthChanged?.Invoke();
    }
}
