using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money_Rotation : MonoBehaviour
{
    public int RotationSpeed;
    public AudioSource CollectSound;
    public GameObject Money;

    void Update()
    {
        transform.Rotate(0, RotationSpeed, 0, Space.World); 
    }

    void OnTriggerEnter(Collider other)
    {
        CollectSound.Play();
        Money.SetActive(false);
    }



}
