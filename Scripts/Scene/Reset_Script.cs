using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset_Script : MonoBehaviour
{

    void Update()
    {
        PlayerHealth.HealthPoints = 100;
        SceneManager.LoadScene(1);
    }
}
