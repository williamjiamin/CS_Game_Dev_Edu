using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectMoney : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCursor;
    public GameObject Money;
    public AudioSource CollectSound;

    void Update()
    {
        TheDistance = PlayerRayCast.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance<=8)
        {
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
            ExtraCursor.SetActive(true);

        }
        else
        {

            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            ExtraCursor.SetActive(false);


        }

        if (Input.GetButtonDown("Action"))
        { 
        
            if(TheDistance <= 8)
            {
                CollectSound.Play();
                Money.SetActive(false);
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ExtraCursor.SetActive(false);

            }

        }


    }
    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        ExtraCursor.SetActive(false);
    }
}
