using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player"){
            TriggerDialogue();
        }
    }

    public void TriggerDialogue(){
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            FindObjectOfType<DialogueManager>().EndDialogue();
        }
    }
}
