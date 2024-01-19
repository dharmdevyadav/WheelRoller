using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreText;
    [SerializeField] Button SpinButton;
    NewBehaviourScript NewRayCastObject;
    private void Awake()
    {
        ScoreText=FindObjectOfType<TextMeshProUGUI>();
        SpinButton = FindObjectOfType<Button>();
        NewRayCastObject=FindObjectOfType<NewBehaviourScript>();
    }
    public void onUnselect()
    {
         DontDestroyOnLoad(ScoreText);
        SceneManager.LoadScene(1);
        //NewRayCastObject.RaycastBlocker.enabled = false;
    }
    
}
