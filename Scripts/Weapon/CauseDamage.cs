using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauseDamage : MonoBehaviour
{
    public int damageAmount;
    public float targetDistance;
    public float damageRange = 4.5f;
    public bool isAttacked = false;



    void Update()
    {
     if (SwordSwing.holdingSword==true)
        {

            if (Input.GetButtonDown("Fire1") && SwordSwing.isSwinging == true)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
                {

                    targetDistance = hit.distance;
                    if (targetDistance<= damageRange)
                    {

                        hit.transform.SendMessage("DeductHealth", damageAmount, SendMessageOptions.DontRequireReceiver);
                    
                    }




                }




            }




        }
    }
}
