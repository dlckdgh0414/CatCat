using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour
{
    [SerializeField] GameObject Playerpos;
    private void Start()
    {
        gameObject.SetActive(false);
        Playerpos = GameObject.Find("Player");
    }
    public void YesClik()
    {
        Time.timeScale = 1;
        Playerpos.transform.position = Vector2.zero;
        UnityEngine.SceneManagement.SceneManager.LoadScene(7);
    }

    public void NoClik()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
