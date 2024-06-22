using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollderPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(9);
            collision.gameObject.SetActive(false);
        }
    }
}
