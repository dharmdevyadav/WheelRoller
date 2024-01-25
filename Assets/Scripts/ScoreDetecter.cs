using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDetecter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreText;
    public Button btn;
    public int btnNumber;
    [SerializeField] Button SpinButton;
    [SerializeField] Button btnCancel;
    NewBehaviourScript ForCancelButton;
    [SerializeField] GameObject PopWindow;
    [SerializeField] GameObject PopWindow2;
    FindNumber wheelnumber;
    TimerCounter timeroverthenpopup;
    public List<int> btnList = new List<int>();
    private void Start()
    {
        timeroverthenpopup=FindObjectOfType<TimerCounter>();
        SpinButton.interactable = false;
        ScoreText = FindObjectOfType<TextMeshProUGUI>();
        ForCancelButton = FindObjectOfType<NewBehaviourScript>();
        wheelnumber = FindObjectOfType<FindNumber>();
        
    }
    public void OnSelectedBtn()
    {
        SpinButton.interactable = true;
         
        if (SpinButton.interactable == true && btnCancel.interactable == true && timeroverthenpopup.currentTimer == 0)
        {
            StartCoroutine(Pop());
        }
        if (btn.interactable == true)
        {
            btn.interactable = false;
            btnNumber = Int32.Parse(btn.name);
            if (timeroverthenpopup.currentTimer < 0 && ForCancelButton.btnSpin.interactable == false && ForCancelButton.RayCastObj == true)
            { 
                PopWindow.SetActive(true);
            }
            btnList.Add(btnNumber);
           
             
        }
        if(SpinButton.interactable == false)
        {
            btn.interactable = false;
            
        }
        
        ForCancelButton.btnCancel.interactable = true;
        
    }

    public IEnumerator Pop()
    {

        while (ForCancelButton.RepeatFlag)
        {
            
            ForCancelButton.RepeatFlag = false;
            
            ForCancelButton.IsActive = true;
            btnCancel.interactable = false;
            yield return new WaitForSeconds(7f);
            SpinButton.interactable = false;
            btnCancel.interactable = true;
            ForCancelButton.Checkpoints.SetActive(true);
            ForCancelButton.IsActive = false;
            

        }
    }
    public void TryToGetSame()
    {
        if (btnList.Contains(btnNumber) ==wheelnumber)
        
        {
            Debug.Log("I Won The Round");
        }
        
    }

}
