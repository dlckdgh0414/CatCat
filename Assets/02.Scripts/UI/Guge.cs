using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Guge : MonoBehaviour
{
    [SerializeField] GameObject GameOver;
    [SerializeField] TextMeshProUGUI fulltext;

    public float x = 0f;

    [SerializeField] Image FishGage;


    private void Update()
    {
        FishGage.fillAmount = x;
        fulltext.text = "∏Ò«•∑Æ: " + x * 100 + "/100";
        if(x<=0)
        {
            x = 0;
        }
        MaxGage();
    }
    private void MaxGage()
    {
        if(x >= 1)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(5);
            GameManager.Instance.Player.SetActive(true);
            UIManager.Instance._pool = true;
            GameObject.FindGameObjectWithTag("Music2").GetComponent<BackGround2>().PlayMusic();
        }
    }

   
}