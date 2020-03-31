using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A01SceneStart : MonoBehaviour
{
    public GameObject fadeInScreen;

    void Start()
    {
        StartCoroutine(SceneWorks());
    }

    IEnumerator SceneWorks()
    {
        yield return new WaitForSeconds(25.5f);
        fadeInScreen.SetActive(false);

       }
}
