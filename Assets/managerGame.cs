using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class managerGame : MonoBehaviour
{
    public health_system playerHealth;

    bool ended=false;

    public void EndGame(){
        if (ended==false){
            ended=true;
            GotoGameOver();
        }
    }

    void GotoGameOver(){
        SceneManager.LoadScene("GameOver");
    }

}
