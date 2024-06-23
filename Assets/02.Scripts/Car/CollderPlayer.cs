using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollderPlayer : MonoBehaviour
{
    [SerializeField] GameObject Playerpos;
    private void Awake()
    {
        Playerpos = GameObject.Find("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(9);
            Playerpos.transform.position = Vector2.zero;
            collision.gameObject.SetActive(false);
        }
    }
}
