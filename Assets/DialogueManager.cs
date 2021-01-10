using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text name;
    public Text dialogue;

    public Animator animator;

    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences=new Queue<string>();
    }

    public void StartDialogue(Dialogue dia){
        animator.SetBool("DialoguePlay",true);
        name.text=dia.name;
        sentences.Clear();

        foreach (string s in dia.sentences)
        {
            sentences.Enqueue(s);
        }
        string sentence=sentences.Dequeue();
        dialogue.text=sentence;
    }
    public void EndDialogue(){
        animator.SetBool("DialoguePlay",false);
    }
}
