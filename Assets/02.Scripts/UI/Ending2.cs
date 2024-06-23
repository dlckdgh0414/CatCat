using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending2 : MonoBehaviour
{
   [SerializeField] GameObject Playerpos;
    private void Start()
    {
        Playerpos = GameObject.Find("Player");
    }
    public void Yes()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(12);
        Playerpos.transform.position = new Vector2(0.74f, -4.53f);
        TextManager.Intance.isFreeze = true;
        Playerpos.SetActive(false);
    }
}
