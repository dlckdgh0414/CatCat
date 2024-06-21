using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirgger : MonoBehaviour
{
    public void YesClik()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        gameObject.SetActive(false);
    }

    public void No()
    {
        gameObject.SetActive(false);
    }
}
