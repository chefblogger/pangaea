using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plattform_control : MonoBehaviour
{

    [SerializeField] GameObject[] waypoints;
    int currentWaypointIndex = 0;

    [SerializeField] float speed = 1.0f;
    [SerializeField] float warteZeit = 3.0f;

    bool isWaiting;
  

    // Update is called once per frame
    void Update()
    {

      Bewegung();  
    } 



    private void Bewegung(){

        if(!isWaiting)
        {

            if (Vector3.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < 1.0f)
            {
                isWaiting = true;
                currentWaypointIndex++;
                

                if (currentWaypointIndex >= waypoints.Length)
                {
                    isWaiting = true;
                    currentWaypointIndex = 0;
                    
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
            
        }
        else
        { 
            isWaiting = true;
            StartCoroutine(wartezeit());
        }
    }

    IEnumerator wartezeit()
    {
        yield return new WaitForSeconds(warteZeit);
        isWaiting = false;
    }




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
