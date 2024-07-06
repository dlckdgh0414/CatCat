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
    private void Start()
    {
        Playerpos = GameObject.Find("Player");

    }
    public void next()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        GameManager.Instance.Player.SetActive(true);
        Playerpos.transform.position = new Vector2(-1.1f, 0.003877744f);
        GameObject.FindGameObjectWithTag("Music").GetComponent<BackGroundMusic>().PlayMusic();

    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Setting()
    {
        setting.gameObject.SetActive(true);
    }

    public void keySetting()
    {
        KeySettingUi.SetActive(true);
    }
}
