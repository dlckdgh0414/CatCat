using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log(Time.timeScale+"ddddd");

    }
    public void next()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
