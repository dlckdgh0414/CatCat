using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject Playerpos;

    private void Awake()
    {
        gameObject.SetActive(true);
        Playerpos = GameObject.Find("Player");
    }
    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        Time.timeScale = 1;
        GameObject.FindGameObjectWithTag("Music").GetComponent<BackGroundMusic>().PlayMusic();
        TextManager.Intance.isFreeze = true;
        UIManager.Instance._pool = false;
        GameManager.Instance.Player.SetActive(true);
        gameObject.SetActive(false);
        Playerpos.transform.position = Vector2.zero;
    }
    
    public void Exit()
    {
        Application.Quit();
        TextManager.Intance.isFreeze = true;
    }
}
