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
    float MaxTime = 20f;
    public float currentTime;
    //private void Awake()
    //{
    //    currentTime = 20f;
    //}
    private void Update()
    {
        currentTime = MaxTime - Time.time;
        TimeTxt.text = $"남은시간:{Mathf.RoundToInt(currentTime)}";
        Size.localScale = new Vector3(x, 1, 1);
        Debug.Log(Size.localScale);
        MaxGage();
        MinTime();

        
    }
    private void MinTime()
    {
        if(currentTime==0 && Time.timeScale == 1)
        {
            GameOver.SetActive(true);
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