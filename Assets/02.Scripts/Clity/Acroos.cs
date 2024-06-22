using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acroos : MonoBehaviour
{
    [SerializeField] GameObject Playerpos; 
    private void Start()
    {
        Playerpos = GameObject.Find("Player");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        TextManager.Intance.isFreeze = true;
        UnityEngine.SceneManagement.SceneManager.LoadScene(8);
        Playerpos.transform.position = new Vector2(-12f, -2);
    }
}
