using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour
{
    public float speed = 3.0f;
    public bool vertical;

    public bool death=false;

    Rigidbody2D rigid;

    public float changeTime=3.0f;
    float timer;
    int direction=1;

    public health_system healthSystem;
    public int dmg;

    // Start is called before the first frame update
    void Start()
    {
        rigid=GetComponent<Rigidbody2D>();    
        timer=changeTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;
        if (timer<0){
            direction=-direction;
            flip();
            timer=changeTime;
        }
    }

    void FixedUpdate()
    {
        Vector2 position = rigid.position;
        if(vertical){
            position.y+=Time.deltaTime*speed*direction;
        }
        else{
            position.x+=Time.deltaTime*speed*direction;
        }
        rigid.MovePosition(position);

        if (death) Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player"){
            healthSystem.DmgAndHeal(dmg);
        }
    }
    void flip(){
        transform.Rotate(0f,180f,0f);
    }
}
