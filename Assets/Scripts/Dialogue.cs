using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]//mark as serializable to be able to edit variables in inspector
public class Dialogue
{
    //Pass into dialogue manager whenever we start a new dialogue
    //host all information we need about a single dialogue

    //Question: why not derive from monobehaviour?

    public string name;
    [TextArea(3,10)]
    public string[] sentences;

   
}
