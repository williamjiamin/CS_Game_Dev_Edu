using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject TheDoor;
    public AudioSource DoorOpenSound;

    void OnTriggerEnter(Collider other)
    {
        DoorOpenSound.Play();
        TheDoor.GetComponent<Animator>().enabled = true;
        TheDoor.GetComponent<Animator>().Play("OpenDoor");
        this.GetComponent<BoxCollider>().enabled = false;
    }
}
