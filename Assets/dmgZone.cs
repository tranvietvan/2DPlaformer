using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmgZone : MonoBehaviour
{
    public health_system healthSystem;
    public int dmg;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player"){
            healthSystem.DmgAndHeal(dmg);
        }
    }
}
