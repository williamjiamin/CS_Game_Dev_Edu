using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRayCast : MonoBehaviour
{
    public static float DistanceFromTarget;
    public float DistanceToTarget;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit))
        {
            DistanceToTarget = hit.distance;
            DistanceFromTarget = DistanceToTarget;
        }
    }
}
