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
    [SerializeField] GameObject Playerpos;
    [SerializeField] GameObject MusicSetting;
    private void Start()
    {
        Playerpos = GameObject.Find("Player");
        MusicSetting = GameObject.Find("Setting");
    }
    public void next()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        GameManager.Instance.Player.SetActive(true);
        Playerpos.transform.position = new Vector2(-1.1f, 0.003877744f);
        
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Setting()
    {
        GameManager.Instance.Menu.SetActive(true);
    }

    public void keySetting()
    {
        KeySettingUi.SetActive(true);
    }
}
