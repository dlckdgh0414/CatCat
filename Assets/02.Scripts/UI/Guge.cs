using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Guge : MonoBehaviour
{
    [SerializeField] GameObject GameOver;


    public  float x = 0f;
    public float trashx = 0f;

    [SerializeField] Image FishGage;
    [SerializeField] Image TrashGage;

    private void Update()
    {
        FishGage.fillAmount = x;
        TrashGage.fillAmount = trashx;
        MaxGage();
    }
    private void MaxGage()
    {
        if(x >= 1)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(6);
        }

        if(trashx >= 1)
        {
            GameOver.SetActive(true);
        }
    }

   
}