using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    [SerializeField] GameObject setting;
    [SerializeField] GameObject KeySettingUi;
    public void next()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Setting()
    {
        setting.SetActive(true);
    }

    public void keySetting()
    {
        KeySettingUi.SetActive(true);
    }
}
