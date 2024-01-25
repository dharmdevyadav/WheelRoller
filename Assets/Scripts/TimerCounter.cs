using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI CurrentTime;
    NewBehaviourScript NewScript;
    float StartingTime = 15f;
    public float currentTimer = 0f;
    ScoreDetecter ScoreScript;
    public GameObject PopupWindow;
    public GameObject PopupWindow2;
    public GameObject TimerWindow;

    void Start()
    {
        ScoreScript = FindObjectOfType<ScoreDetecter>();
        NewScript = FindObjectOfType<NewBehaviourScript>();
        TimerWindow.SetActive(true);
        PopupWindow.SetActive(false);
        PopupWindow2.SetActive(false);
        currentTimer = StartingTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer -= 1 * Time.deltaTime;
        CurrentTime.text = currentTimer.ToString("0");
        if (currentTimer <1&&NewScript.btnSpin.interactable==false)
        {
            PopupWindow.SetActive(true);
        }
        if (currentTimer < 0)
        {
            NewScript.RayCastObj.SetActive(true);
            currentTimer = 0;

        }

        if (currentTimer <= 0 && NewScript.RayCastObj == true&&NewScript.btnCancel.interactable == false)
        {
            Invoke("RestartGame",25);
        }
        if (NewScript.buttonSpinClicked)
        {
            TimerWindow.SetActive(false);
            currentTimer = 15;
        }
    }
    public void button1_Click()
    {
        NewScript.buttonSpinClicked = true;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
