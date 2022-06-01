
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;



        

public class AutoRotate : UdonSharpBehaviour
{
  
  public float ySpeed = 0.3f;
  public float xSpeed = 0f;
  public float zSpeed = 0f;

  public GameObject thingToRotate; 


    void Update()
   {
       thingToRotate.transform.Rotate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime);
   }
}
