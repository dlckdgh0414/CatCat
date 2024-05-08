using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirgger : MonoBehaviour
{
    [SerializeField] GameObject UI;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            UI.SetActive(true);
            Time.timeScale = 0; 
        }
    }
}
