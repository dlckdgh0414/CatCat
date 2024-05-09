using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject UI;
    Guge Timer;

    private void Awake()
    {
        Timer = GetComponent<Guge>();
        UI.SetActive(false);
    }
    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        Timer.currentTime = 20f;
        Time.timeScale = 1;
    }
}
