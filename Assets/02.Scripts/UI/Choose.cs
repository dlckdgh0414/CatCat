using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choose : MonoBehaviour
{
   public void YesClik()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(4);
        GameObject.FindWithTag("Player").SetActive(false);
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
    }

    public void NoClik()
    {
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
    }
}
