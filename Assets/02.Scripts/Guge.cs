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
    int MaxTime = 20;
    float currentTime;
    private void Update()
    {
        currentTime = Mathf.RoundToInt(MaxTime - Time.time);
        Debug.Log(currentTime);
        TimeTxt.text = $"남은시간:{currentTime}";
        Size.localScale = new Vector3(x, 1, 1);
        Debug.Log(Size.localScale);
        MaxGage();
        MinTime();
    }
    private void MinTime()
    {
        if(currentTime==0)
        {
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