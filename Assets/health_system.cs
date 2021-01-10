using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_system : MonoBehaviour
{
    public int maxHealth=10;
    public int currentHealth=8;

    public float timeInvincible = 2.0f;
    public bool isInvincible=false;
    float invincibleTimer;

    public healthbar healthBar;

    public managerGame gameManager;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {   
        if (isInvincible){
            invincibleTimer-=Time.deltaTime;
            if(invincibleTimer<0){
                isInvincible=false;
            }
        }
        healthBar.SetHealth(currentHealth);
        if (currentHealth==0){
            FindObjectOfType<managerGame>().EndGame();
        }
    }

    public void DmgAndHeal(int health){

        if (health<0){
            if (isInvincible) return;
            isInvincible=true;
            invincibleTimer=timeInvincible;
        }

        currentHealth+=health;
        if (currentHealth<0) currentHealth=0;
        if (currentHealth>maxHealth) currentHealth=maxHealth;
    }
}
