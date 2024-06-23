using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Town : MonoBehaviour
{
    [SerializeField] GameObject Playerpos;
    private void Start()
    {
        Playerpos = GameObject.Find("Player");
    }
    private void Awake()
    {
        gameObject.SetActive(false);
    }
    public void YesClik()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(10);
        Playerpos.transform.position = new Vector2(-23.83f, 0.23f);
        TextManager.Intance.isFreeze = true;
        GameObject.FindGameObjectWithTag("Music3").GetComponent<BackGroundMusic3>().StopMusic();
        gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("Music4").GetComponent<BackGroundMusic4>().StopMusic();
    }

    public void NoClik()
    {
        gameObject.SetActive(false);
    }
}
