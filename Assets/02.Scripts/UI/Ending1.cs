using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending1 : MonoBehaviour
{
    EndingCollder game;
    [SerializeField] GameObject Playerpos;

    private void Start()
    {
        game = GetComponent<EndingCollder>();
        Playerpos = GameObject.Find("Player");
    }
    public void YesButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(11);
        GameObject.FindGameObjectWithTag("Music4").GetComponent<BackGroundMusic4>().StopMusic();
        Playerpos.SetActive(false);
        gameObject.SetActive(false);
    }

    public void NoButton()
    {
        gameObject.SetActive(false);
    }
}
