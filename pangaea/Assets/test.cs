using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
   
   //check if collision with player 
    private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.tag == "Player")
         {
              Debug.Log("collision");
              
         }
    }
   
}
