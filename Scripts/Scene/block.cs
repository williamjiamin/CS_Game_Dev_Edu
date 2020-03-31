using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    public GameObject show_blocker_text;

    void OnTriggerEnter(Collider other)
    {
        show_blocker_text.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        show_blocker_text.SetActive(false);
    }
}
