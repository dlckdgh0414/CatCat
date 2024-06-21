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
        GameObject.FindGameObjectWithTag("Music2").GetComponent<BackGround2>().StopMusic();
    }

    public void NoClik()
    {
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
    }
}
