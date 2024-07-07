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
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
        Time.timeScale = 1;
        TextManager.Intance.isFreeze = true;
        UIManager.Instance._pool = false;
        GameManager.Instance.Player.SetActive(true); 
        gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("Music3").GetComponent<BackGroundMusic3>().PlayMusic();
    }

    public void Exit()
    {
        Application.Quit();
        TextManager.Intance.isFreeze = true;
    }
}

