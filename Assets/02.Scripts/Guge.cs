using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guge : MonoBehaviour
{
    [SerializeField] RectTransform Size;
    public  float x = 0f;

    private void Update()
    {
        Size.localScale = new Vector3(x, 1, 1);
        Debug.Log(Size.localScale);
    }
}