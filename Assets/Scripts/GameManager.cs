using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject scoreText;
    
    

    private void Start()
    {
        
    }
   
    public void onUnselect()
    {
        
        SceneManager.LoadScene(1);
        
    }
    
}
