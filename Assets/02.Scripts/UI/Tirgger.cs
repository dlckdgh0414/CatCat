using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirgger : MonoBehaviour
{
    public bool _pool;
    public void YesClik()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
    }

    public void No()
    {
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
    }
}
