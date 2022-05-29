using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plattform_sticky : MonoBehaviour
{

 // player parent to plattform
    private void OnCollisionEnter(Collision other)
    {
        other.transform.parent = transform;
    }

     private void OnCollisionExit(Collision other)
    {
        other.transform.parent = null;
    }
    
}
