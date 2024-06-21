using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject Playerpos;

    private void Awake()
    {
        Playerpos = GameObject.Find("Player");
    }
    public void Restart()
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        GameObject.FindGameObjectWithTag("Music").GetComponent<BackGroundMusic>().PlayMusic();
        Playerpos.transform.position = Vector2.zero;
    }
    
    public void Exit()
    {
        Application.Quit();
    }
}
