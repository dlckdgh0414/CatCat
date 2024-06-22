using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCar : MonoBehaviour
{
    [SerializeField] GameObject Playerpos;

    private void Start()
    {
        Playerpos = GameObject.Find("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
        Playerpos.transform.position = new Vector2(65.3F, -0.4f);
    }
}
