using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
  /*[SerializeField]private float ScalingSpeed;
  [SerializeField] private Vector3 minScale;
  [SerializeField] private Vector3 maxScale;
  [SerializeField] private float ScalingDuration;*/
  public bool RepeatFlag;
  public bool IsActive;
    public bool buttonSpinClicked = false;
    public GameObject wheel;
    public GameObject Ball;
    public GameObject Checkpoints;
    public Button btnSpin;
    public Button btnCancel;
    public GameObject RayCastObj;
    ScoreDetecter GetSameNumber;
    
    
   
    private void Start()
    {
        GetSameNumber=FindObjectOfType<ScoreDetecter>();
        RayCastObj.SetActive(false);
        Checkpoints.SetActive(false);
        btnCancel.interactable = false; 
      
    }
    public void PopUp()
  {
    RepeatFlag = true;
        RayCastObj.SetActive(true);
        Checkpoints.SetActive(false);
    StartCoroutine(Pop());

    }
   
    public void RotateMyBall()
    {
        //Gameobject.transform.localPosition = new Vector3(0.6f, 0.03f, 0.08f);
        Ball.transform.localRotation=Quaternion.Euler(0, 0, Random.Range(15,30));
    }

  public void RotateMyObject()
  {
    transform.Rotate(new Vector3(0, 0,-Random.Range(5f,20f)));
  }
  public IEnumerator Pop()
  {

    while (RepeatFlag)
    {
      //yield return RepeatingFlag(minScale, maxScale, ScalingDuration);
      RepeatFlag = false;
      // InvokeRepeating("RotateMyObject",1f,(0.4f/ScalingDuration));
      IsActive = true;
            btnCancel.interactable = false;
            yield return new WaitForSeconds(7f);
            GetSameNumber.TryToGetSame();
            btnSpin.interactable =false;
            btnCancel.interactable = true;
            Checkpoints.SetActive(true);
            IsActive = false;
      // CancelInvoke();
     // yield return RepeatingFlag(maxScale, minScale, ScalingDuration);

    }
  }
   
  /*IEnumerator RepeatingFlag(Vector3 startScale,Vector3 endScale,float time)
  {*/
    /*float t = 0.0f;
    float rate = (1f / time) * ScalingSpeed;
    while (t < 1f)
    {
      t += Time.deltaTime * rate;
      transform.localScale=Vector3.Lerp(startScale, endScale, t);*/
     // yield return null;
   // }
  
  private void Update()
  {
    if (IsActive==true)
    {
      RotateMyObject();
      btnSpin.interactable = false;
      Invoke("RotateMyBall",0.4f);
    }
    else
    {
      Ball.transform.GetChild(0).localPosition = new Vector3(0.04f,-0.06f,-0.68f);
    }
    
  }

}
