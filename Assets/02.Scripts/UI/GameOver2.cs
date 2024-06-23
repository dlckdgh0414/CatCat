using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver2 : MonoBehaviour
{
    [SerializeField] GameObject Playerpos;

    private void Awake()
    {
        gameObject.SetActive(true);
        Playerpos = GameObject.Find("Player");
    }
    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        Time.timeScale = 1;
        TextManager.Intance.isFreeze = true;
        UIManager.Instance._pool = false;
        gameObject.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
        TextManager.Intance.isFreeze = true;
    }
}
