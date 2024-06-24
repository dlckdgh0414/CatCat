using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acroos : MonoBehaviour
{
    [SerializeField] GameObject Playerpos;
    AcroosSinge singe;
    private void Start()
    {
        Playerpos = GameObject.Find("Player");
        singe = GetComponentInParent<AcroosSinge>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!singe.isOn)
        { 
            UnityEngine.SceneManagement.SceneManager.LoadScene(8);
            GameObject.FindGameObjectWithTag("Music3").GetComponent<BackGroundMusic3>().StopMusic();
            Playerpos.transform.position = new Vector2(-12f, -2);
        }
    }
}
