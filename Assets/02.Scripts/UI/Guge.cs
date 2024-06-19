using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Guge : MonoBehaviour
{
    [SerializeField] GameObject GameOver;


    public  float x = 0f;

    [SerializeField] Image FishGage;

    private void Update()
    {
        FishGage.fillAmount = x;
        MaxGage();
    }
    private void MaxGage()
    {
        if(x >= 1)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(6);
            GameObject.FindWithTag("Player").SetActive(true);
        }
    }

   
}