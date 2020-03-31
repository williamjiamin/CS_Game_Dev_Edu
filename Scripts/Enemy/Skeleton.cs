using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Skeleton : MonoBehaviour
{
    public int enemyHealth = 100;
    public GameObject Zone_object;
   
    void DeductHealth(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }



    void Update()
    {
        if(enemyHealth<=0)
        {
            //this.gameObject.SetActive(false);     
            this.GetComponent<Animator>().Play("Death");
            this.GetComponent<Nav_AI>().enabled = false;
            this.GetComponent<NavMeshAgent>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;

            Zone_object.SetActive(false);
        }
    }
}
