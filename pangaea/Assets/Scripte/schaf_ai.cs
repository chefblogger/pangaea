using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schaf_ai : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    public Transform[] wegpunkte;
    int waypointIndex;
    Vector3 target;

    int Zufallszahl;
    public int Ziel;

    //int WaitTime = 3;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        UpdateDestination();
    }


    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1)
        {
            IterateWaypointIndex();
            
            UpdateDestination();

            Zufallszahl = Random.Range(0, wegpunkte.Length);
        }

      //transform.position += transform.forward * Time.deltaTime;  
    }

    void UpdateDestination()
    {
        target = wegpunkte[waypointIndex].position;


        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        //waypointIndex++;
        waypointIndex = Zufallszahl;
        Ziel = waypointIndex;

        if (waypointIndex == wegpunkte.Length)
        {
            waypointIndex = 0;
        }
    }
}
