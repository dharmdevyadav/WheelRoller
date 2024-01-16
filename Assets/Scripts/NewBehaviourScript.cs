using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
  [SerializeField]private float ScalingSpeed;
  [SerializeField] private Vector3 minScale;
  [SerializeField] private Vector3 maxScale;
  [SerializeField] private float ScalingDuration;
  public bool RepeatFlag;
  private bool IsActive;
  public GameObject wheel;
    public GameObject Gameobject;
  Rigidbody2D rb;
  public void PopUp()
  {
    RepeatFlag = true;
    
    StartCoroutine(Pop());
    
  }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Touched number:"+other.name);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Touched something out");
        }
    }
    public void MyCoroutineStop()
  {
    StopAllCoroutines();
    transform.localScale=new Vector3(0.9f, 0.9f,0.9f);
       // transform.GetChild(0).localScale = new Vector3(0.9f, 0.9f, 0.9f);
    }

    public void RotateMyBall()
    {
        //Gameobject.transform.localPosition = new Vector3(0.6f, 0.03f, 0.08f);
        Gameobject.transform.localRotation=Quaternion.Euler(0, 0, Random.Range(6,10));
    }

  public void RotateMyObject()
  {
    transform.Rotate(new Vector3(0, 0, 5.5f));
  }
  IEnumerator Pop()
  {

    while (RepeatFlag)
    {
      yield return RepeatingFlag(minScale, maxScale, ScalingDuration);
      RepeatFlag = false;
      // InvokeRepeating("RotateMyObject",1f,(0.4f/ScalingDuration));
      IsActive = true;
      yield return new WaitForSeconds(7f);
      IsActive = false;
      // CancelInvoke();
      yield return RepeatingFlag(maxScale, minScale, ScalingDuration);

    }
  }
   
  IEnumerator RepeatingFlag(Vector3 startScale,Vector3 endScale,float time)
  {
    float t = 0.0f;
    float rate = (1f / time) * ScalingSpeed;
    while (t < 1f)
    {
      t += Time.deltaTime * rate;
      transform.localScale=Vector3.Lerp(startScale, endScale, t);
      yield return null;
    }
  }
  private void Update()
  {
    if (IsActive==true)
    {
      RotateMyObject();
      Invoke("RotateMyBall",0.4f);
        }
        else
        {
            Gameobject.transform.GetChild(0).localPosition = new Vector3(0.04f,-0.06f,-0.68f);
        }
    
  }

}
