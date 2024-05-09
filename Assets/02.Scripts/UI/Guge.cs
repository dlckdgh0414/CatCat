using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guge : MonoBehaviour
{
    [SerializeField] RectTransform Size;
    [SerializeField] GameObject GameOver;
    public Text TimeTxt;
    public  float x = 0f;
    float MaxTime = 25;
    public float currentTime;
    public float oldTime;
    //private void Awake()
    //{
    //    currentTime = 20f;
    //}

    private void Start()
    {
        currentTime = MaxTime;
        oldTime = Time.time;
        Time.timeScale = 1;
    }
    private void Update()
    {
        currentTime = MaxTime + oldTime - Time.time;
        TimeTxt.text = $"남은시간:{Mathf.Round(currentTime)}";
        Size.localScale = new Vector3(x, 1, 1);
        Debug.Log(Size.localScale);
        MaxGage();
        MinTime();
    }
    private void MinTime()
    {
        if(currentTime<=0)
        {
            Debug.Log(currentTime);
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
    private void MaxGage()
    {
        if(x >= 1)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(6);
        }
    }
}