using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences; //keep track of all current sentences in dialogue
    void Start()
    {
        sentences = new Queue<string>();

    }

} 
