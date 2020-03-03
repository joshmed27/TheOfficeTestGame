using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    //feed back to dialoguemanager

    public void TriggerDialogue()
    {
        //locate dialogue manager
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
        
    
}
