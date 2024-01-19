using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDetecter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreText;
    //float Score;
    public Button btn;
    [SerializeField] Button SpinButton;
    NewBehaviourScript ForCancelButton;
    private void Start()
    {
        SpinButton.interactable = false;
        ScoreText = FindObjectOfType<TextMeshProUGUI>();
        ForCancelButton = FindObjectOfType<NewBehaviourScript>();
    }
    public void OnSelectedBtn()
    {
        SpinButton.interactable = true;
        if (btn.interactable == true)
        {
            btn.interactable = false;
            
        }
        if(SpinButton.interactable == false)
        {
            btn.interactable = false;
        }
        
       // SpinButton.interactable = true;
        ForCancelButton.btnCancel.interactable = true;
        
    }
    
}
