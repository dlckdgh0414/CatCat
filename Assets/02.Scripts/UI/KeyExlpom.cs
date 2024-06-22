using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyExlpom : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(false);
        }
    }
    public void Xbutton()
    {
        gameObject.SetActive(false);
    }
}
