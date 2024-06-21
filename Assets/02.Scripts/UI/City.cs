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
            Playerpos.transform.position = Vector2.zero;
            UnityEngine.SceneManagement.SceneManager.LoadScene(7);
            gameObject.SetActive(false);
            TextManager.Intance.isFreeze = true;
        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(8);
            gameObject.SetActive(false);
            TextManager.Intance.isFreeze = true;
        }
    }

    public void NoClik()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
