using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole_die : MonoBehaviour
{
    public health_system healthSystem;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player"){
            healthSystem.isInvincible=false;
            healthSystem.currentHealth=0;
        }    
    }
}
