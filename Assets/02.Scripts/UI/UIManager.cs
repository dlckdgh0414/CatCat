using System;
using System.Collections;

using UnityEngine;

using UnityEngine.Playables;


public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public PlayableDirector timeLine;
    [SerializeField] GameObject Playerpos;
    [SerializeField] GameObject Image;
    public bool _pool;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        Playerpos = GameObject.Find("Player");
    }

    public void UpOnClik(int sceneNum)
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNum);
        Playerpos.transform.position = new Vector2(-14.43F,0.09f);
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("Music").GetComponent<BackGroundMusic>().StopMusic();
    }
    public void DownOnClik(int sceneNum)
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNum);
        Playerpos.transform.position = new Vector2(-5f,0.03f);
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("Music").GetComponent<BackGroundMusic>().PlayMusic();
    }
}
