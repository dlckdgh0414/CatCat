using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HileBack : MonoBehaviour
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
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        TextManager.Intance.isFreeze = true;
        Playerpos.transform.position = new Vector2(109F, -30.748f);
    }

    public void NoClik()
    {
        gameObject.SetActive(false);
    }
}
