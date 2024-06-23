using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityBack : MonoBehaviour
{
    [SerializeField] GameObject Playerpos;

    private void Start()
    {
        Playerpos = GameObject.Find("Player");
    }

    public void YesClik()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
        Playerpos.transform.position = new Vector2(106.18f, -5.42f);
        TextManager.Intance.isFreeze = true;
    }

    public void NoClik()
    {
        gameObject.SetActive(false);
        TextManager.Intance.isFreeze = true;
    }

}
