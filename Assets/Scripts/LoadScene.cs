using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadSCNE(string SceneName)
    {
        //Using Scene Manager to load the selected scene
        SceneManager.LoadScene(SceneName);
    }
}
