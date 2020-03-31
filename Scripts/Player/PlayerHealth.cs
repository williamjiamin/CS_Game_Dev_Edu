using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public static int HealthPoints = 700;
    public int internal_Health_Points;
    public GameObject HealthDisplay;
    public GameObject HealthBar;






    void Update()
    {
        internal_Health_Points = HealthPoints;
        //HealthDisplay.GetComponent<Text>().text = "玩家生命值：" + HealthPoints;
        HealthBar.GetComponent<RectTransform>().sizeDelta = new Vector2(HealthPoints, 30);
        if (HealthPoints<=0)
        {

            SceneManager.LoadScene(0);
        
        }
    }
}
