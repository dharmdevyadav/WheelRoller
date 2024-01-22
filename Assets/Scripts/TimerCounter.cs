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
    float currentTimer = 0f;
    ScoreDetecter ScoreScript;
    // Start is called before the first frame update
    void Start()
    {
        ScoreScript = FindObjectOfType<ScoreDetecter>();
        NewScript = FindObjectOfType<NewBehaviourScript>();
        currentTimer = StartingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer -= 1 * Time.deltaTime;
        CurrentTime.text = currentTimer.ToString("0");
        if (currentTimer < 0)
        {
            NewScript.RayCastObj.SetActive(true);
            currentTimer = 0;

        }
        if (currentTimer <= 0 && NewScript.RayCastObj == true&&NewScript.btnCancel.interactable == false)
        {
            Invoke("RestartGame", 16);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
