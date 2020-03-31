using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Talk : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCursor;
    public GameObject subtitle;
    public GameObject subtitle_box;
    public GameObject blocker;
    public GameObject blocker_trigger;


    void Update()
    {
        TheDistance = PlayerRayCast.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 8)
        {   
            ActionText.GetComponent<Text>().text = "跟小精灵小姐姐说话~Talk to the Fairy~";
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
            if (TheDistance <= 8)
            {
                if (talk_state.WeaponState ==false)
                {
                    subtitle_box.SetActive(true);
                    subtitle.GetComponent<Text>().text = "你区区一个人类敢跟精灵族说话？快滚！！！You are just a human, you have no right to talk to me , You are too weak";
                    ActionDisplay.SetActive(false);
                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionText.SetActive(false);
                    ExtraCursor.SetActive(false);
                    StartCoroutine(ResetTalk());
                }
                if (talk_state.WeaponState == true)
                {
                    subtitle_box.SetActive(true);
                    subtitle.GetComponent<Text>().text = "什么！你手中拿着的是生命之剑吗？你一个人类竟然能够拿起生命之剑！你难道是传说中的天选之人！那么能帮忙杀掉外面的BOSS吗？";
                    ActionDisplay.SetActive(false);
                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionText.SetActive(false);
                    ExtraCursor.SetActive(false);
                    blocker.SetActive(false);
                    blocker_trigger.SetActive(false);
                    StartCoroutine(ResetTalk());
                }
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
    IEnumerator ResetTalk()
    {
        yield return new WaitForSeconds(5.5f);
        subtitle_box.SetActive(false);
        subtitle.GetComponent<Text>().text = "";
        this.GetComponent<BoxCollider>().enabled = true;

    }
}





