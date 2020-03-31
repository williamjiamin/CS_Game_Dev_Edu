using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_AI : MonoBehaviour
{
    public GameObject theEnemy;
    public bool isAttacking = false;
    public AudioSource SwingSound;

    void OnTriggerEnter(Collider other)
    {
        if (isAttacking==false)
        {
            isAttacking = true;
            theEnemy.GetComponent<Animator>().Play("Attack");
            this.GetComponent<MeshCollider>().enabled=false;
            theEnemy.GetComponent<Nav_AI>().enabled=false;
            theEnemy.GetComponent<NavMeshAgent>().enabled=false;
            StartCoroutine(TakeHealth());

        }
    }




    void OnTriggerExit(Collider other)
    {
        StopCoroutine(TakeHealth());
        isAttacking = false;
        theEnemy.GetComponent<Animator>().Play("Walk");
        this.GetComponent<MeshCollider>().enabled = true;
        theEnemy.GetComponent<Nav_AI>().enabled = true;
        theEnemy.GetComponent<NavMeshAgent>().enabled = true;
       

    }


    IEnumerator TakeHealth()
    {
        yield return new WaitForSeconds(1.1f);
        SwingSound.Play();
        yield return new WaitForSeconds(1.1f);



        PlayerHealth.HealthPoints -= 300;

        isAttacking = false;
        theEnemy.GetComponent<Animator>().Play("Walk");
        this.GetComponent<MeshCollider>().enabled = true;
        theEnemy.GetComponent<Nav_AI>().enabled = true;
        theEnemy.GetComponent<NavMeshAgent>().enabled = true;

    }













}
