using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dayChanger : MonoBehaviour
{
    public Text instruction;
    int day = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        dayChange();
    }
    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainScene");
    }

    public void dayChange()
    {
        day++;
        instruction = GetComponent<Text>();
        instruction.text = "Day " + day;
        StartCoroutine(Wait2());
    }
}
