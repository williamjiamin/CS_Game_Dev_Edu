using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordTake : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCursor;
    public GameObject FakeSword;
    public GameObject RealSword;
    public AudioSource CollectSound;


    void Update()
    {
        TheDistance = PlayerRayCast.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance<=8)
        {
            ActionText.GetComponent<Text>().text = "Take the Sword of Life and Save the World!!!!!";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
            ExtraCursor.SetActive(true);
        }
        else
        {
            ActionText.GetComponent<Text>().text = "";
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            ExtraCursor.SetActive(false);
        }


        if (Input.GetButtonDown("Action"))
        { 
            if (TheDistance<=8)
            {
                ActionText.GetComponent<Text>().text = "";
                CollectSound.Play();
                RealSword.SetActive(true);
                FakeSword.SetActive(false);
                SwordSwing.holdingSword = true;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                talk_state.WeaponState=true;
                Destroy(gameObject);

            }

        }



    }
    void OnMouseExit()
    {
        ActionText.GetComponent<Text>().text = "";
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        ExtraCursor.SetActive(false);
    }

}





