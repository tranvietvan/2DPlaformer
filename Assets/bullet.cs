﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed=20f;
    public Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid.velocity=transform.right*speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Enemy"){
            collision.gameObject.GetComponent<EnemiesController>().death=true;
        }
        Destroy(gameObject);
    }

}
