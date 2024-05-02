using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    protected float _currentHealth;

    [SerializeField]
    protected float _maximumHealth;

    public virtual void TakeDamamge(float damageAmount)
    {
        _currentHealth -= damageAmount;
    }
}
