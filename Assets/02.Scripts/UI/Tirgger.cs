using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirgger : MonoBehaviour
{
    [SerializeField] GameObject UI;
    BoxCollider2D box;

    private void Awake()
    {
        box = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            UI.SetActive(true);
            box.isTrigger = true;
            Time.timeScale = 0; 
        }
    }
}
