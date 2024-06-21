using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReChoose : MonoBehaviour
{
    [SerializeField] GameObject Playerpos;
    private void Start()
    {
        Playerpos = GameObject.Find("Player");
    }

    public void UpBottun()
    {
        TextManager.Intance.isFreeze = true;
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        Playerpos.transform.position = Vector2.zero;
        GameObject.FindGameObjectWithTag("Music2").GetComponent<BackGround2>().StopMusic();
        GameObject.FindGameObjectWithTag("Music").GetComponent<BackGroundMusic>().PlayMusic();
    }

    public void DownBottun()
    {
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
    }
}
