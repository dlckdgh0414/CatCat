using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guge : MonoBehaviour
{
    [SerializeField] RectTransform Size;
    [SerializeField] GameObject GameOver;
    public  float x = 0f;
    private void Update()
    {
        Size.localScale = new Vector3(x, 1, 1);
        MaxGage();
    }
    private void MaxGage()
    {
        if(x >= 1)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(6);
        }
    }
}