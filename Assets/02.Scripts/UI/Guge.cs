using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guge : MonoBehaviour
{
    [SerializeField] RectTransform Size;
    [SerializeField] RectTransform TrashSize;
    //[SerializeField] GameObject GameOver;
    public  float x = 0f;
    public float trashx = 0f;
    private void Update()
    {
        Size.localScale = new Vector3(x, 1, 1);
        TrashSize.localScale = new Vector3(trashx, 1, 1);
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