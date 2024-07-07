using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoIiveingRoom : MonoBehaviour
{
    [SerializeField] GameObject Playerpos;

    private void Start()
    {
        Playerpos = GameObject.Find("Player");
    }
    public void YesClik()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(15);
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
        TextManager.Intance.isChoosing = false;

    }

    public void NoClik()
    {
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
        TextManager.Intance.isChoosing = false;
    }
}
