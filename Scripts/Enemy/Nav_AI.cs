using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nav_AI : MonoBehaviour
{
    public GameObject the_Destination;
    NavMeshAgent theAgent;

    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
    }

 
    void Update()
    {
        theAgent.SetDestination(the_Destination.transform.position);
    }
}
