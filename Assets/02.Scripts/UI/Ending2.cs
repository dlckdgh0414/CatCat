using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending2 : MonoBehaviour
{
   [SerializeField] GameObject Playerpos;
    public bool isEnd { get; set; }

    public static Ending2 Intance;

    private void Awake()
    {
       if(Intance == null)
        {
            Intance = this;
        }
       else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Playerpos = GameObject.Find("Player");
    }
    public void Yes()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(12);
        gameObject.SetActive(false);
        Playerpos.transform.position = new Vector2(0.74f, -4.53f);
        GameObject.FindGameObjectWithTag("Music4").GetComponent<BackGroundMusic4>().StopMusic();
        TextManager.Intance.isFreeze = true;
        Playerpos.SetActive(false);
    }
}
