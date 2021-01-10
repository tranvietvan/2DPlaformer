using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform FirePoint;
    public Animator animator;
    public GameObject bullet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            Shoot();
        }
    }

    void Shoot(){
        Instantiate(bullet, FirePoint.position,FirePoint.rotation);
    }
}
