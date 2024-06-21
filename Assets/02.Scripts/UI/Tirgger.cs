using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirgger : MonoBehaviour
{
    public bool _pool;
    [SerializeField] GameObject Playerpos;
    private void Start()
    {
        Playerpos = GameObject.Find("Player");
    }
    public void YesClik()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        Playerpos.transform.position = Vector2.zero;
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
    }

    public void No()
    {
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
    }
}
