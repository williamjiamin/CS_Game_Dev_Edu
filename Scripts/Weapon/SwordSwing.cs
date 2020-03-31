using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{
    public GameObject theSword;
    public static bool isSwinging = false;
    public AudioSource swingSound;
    public static bool holdingSword = false;




    void Update()
    {   if (holdingSword == true)
        {
            if (Input.GetButtonDown("Fire1") && isSwinging == false)
            {

                isSwinging = true;
                StartCoroutine(SwingtheSword());

            }
        }
    }

    IEnumerator SwingtheSword()
    {

        swingSound.Play();
        theSword.GetComponent<Animation>().Play("SwingSword");
        yield return new WaitForSeconds(1.05f);
        isSwinging = false;




    }




}



