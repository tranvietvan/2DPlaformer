using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_controller : MonoBehaviour
{

    public float speed;
    public float jumpPower;
    private Rigidbody2D rigid;

    private bool onGround=false;
    public Transform groundCheck;
    public LayerMask groundLayer; 

    public Animator animator;

    bool faceFw=true;

    void Start()
    {
        rigid=GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        onGround=Physics2D.OverlapCircle(groundCheck.position,0.2f,groundLayer);

        if (onGround) animator.SetBool("Jump",false);

        if ((Input.GetKeyDown(KeyCode.UpArrow)) && onGround)
        {
            rigid.AddForce(new Vector2(0f,jumpPower), ForceMode2D.Impulse);
            animator.SetBool("Jump",true);
        }

        float horizontal = Input.GetAxis("Horizontal");

        bool isWalking=false;
        if (horizontal!=0){
            isWalking=true;
        }
        animator.SetBool("Walk",isWalking);

        Vector2 position = transform.position;
        position.x += (0.01f * speed * horizontal);
        transform.position = position;

        if (horizontal<0 && faceFw){
            flip();
        }
        if (horizontal>0 && !faceFw){
            flip();
        }
    }

    void flip(){
        faceFw=!faceFw;
        transform.Rotate(0f,180f,0f);
    }
}
