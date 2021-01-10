using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthpack : MonoBehaviour
{
    public health_system healthSystem;
    public int health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        healthSystem.DmgAndHeal(health);
        Destroy(gameObject);
    }
}
