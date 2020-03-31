using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset_the_Game : MonoBehaviour
{
    public void Reset_All()
    {

        PlayerHealth.HealthPoints = 700;
        SceneManager.LoadScene(1);


    }



}
