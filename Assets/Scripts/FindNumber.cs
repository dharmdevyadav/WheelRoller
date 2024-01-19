using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindNumber : MonoBehaviour
{
    
    //BoxCollider collider;
    NewBehaviourScript WheelScript;
    bool istrue;
    private void Awake()
    {
        //collider = GetComponent<BoxCollider>();
        WheelScript = FindObjectOfType<NewBehaviourScript>();
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
            {
                Debug.Log("Ball stands on number: " + gameObject.name);
                Debug.DebugBreak();
            }
    }
}
