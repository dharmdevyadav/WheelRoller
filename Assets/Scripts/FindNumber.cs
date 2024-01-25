using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FindNumber : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    NewBehaviourScript WheelScript;
    ScoreDetecter ScoreFinding;
    int score1;
    public int number;
            
    private void Awake()
    {
        ScoreFinding=FindObjectOfType<ScoreDetecter>();
        WheelScript = FindObjectOfType<NewBehaviourScript>();
        score1 = 0;
        number =Int32.Parse(gameObject.name);
        
    }

    public int AddedScore()
    {
       
        int score = int.Parse(gameObject.name);

        if (score > 0 && score < 5)
        {
            score1 = 10;
            ScoreText.text = "Score: " + score1.ToString();

        }
        else if (score > 5 && score <= 10)
        {
            score1 = 20;
            ScoreText.text = "Score: " + score1.ToString();
        }
        else if (score > 10 && score <= 15)
        {
            score1 = 30;
            ScoreText.text = "Score: " + score1.ToString();
        }
        else if (score > 15 && score <= 20)
        {
            score1 = 30;
            ScoreText.text = "Score: " + score1.ToString();
        }
        else if (score > 20 && score <= 25)
        {
            score1 = 35;
            ScoreText.text = "Score: " + score1.ToString();
        }
        else if (score > 25 && score <= 30)
        {
            score1 = 40;
            ScoreText.text = "Score: " + score1.ToString();
        }
        else if (score > 30 && score <= 36)
        {
            score1 = 50;
            ScoreText.text = "Score: " + score1.ToString();
        }
        else
        {
            ScoreText.text = "Score: " + score1.ToString();
        }
        return score1;
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("Ball stands on number: " + gameObject.name);
            AddedScore();
            ScoreFinding.TryToGetSame(); 
        }
        /*if (number == ScoreFinding.btnNumber)
        {
            Debug.Log("YYou Wonnn!");
        }*/

    }
    

}
