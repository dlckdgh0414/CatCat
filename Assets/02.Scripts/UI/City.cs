using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour
{
    [SerializeField] GameObject Playerpos;
    private Tirgger tirgger;
    private void Start()
    {
        tirgger = GetComponent<Tirgger>();
        Playerpos = GameObject.Find("Player");
    }
    public void YesClik()
    {
        if(UIManager.Instance._pool)
        {
            Time.timeScale = 1;
            Playerpos.transform.position = new Vector2(-37.1f,9.6f);
            UnityEngine.SceneManagement.SceneManager.LoadScene(6);
            gameObject.SetActive(false);
            GameObject.FindGameObjectWithTag("Music").GetComponent<BackGroundMusic>().StopMusic();
            GameObject.FindGameObjectWithTag("Music3").GetComponent<BackGroundMusic3>().PlayMusic();
            TextManager.Intance.isFreeze = true;
            TextManager.Intance.isChoosing = false;
        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(7);
            GameObject.FindGameObjectWithTag("Music").GetComponent<BackGroundMusic>().StopMusic();
            gameObject.SetActive(false);
            TextManager.Intance.isFreeze = true;
            TextManager.Intance.isChoosing = false;
        }
    }

    public void NoClik()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
        TextManager.Intance.isChoosing = false;
    }
}
