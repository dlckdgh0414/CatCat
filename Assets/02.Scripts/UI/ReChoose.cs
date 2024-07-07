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
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        Playerpos.transform.position = Vector2.zero;
        TextManager.Intance.isFreeze = true;
        GameObject.FindGameObjectWithTag("Music2").GetComponent<BackGround2>().StopMusic();
        GameObject.FindGameObjectWithTag("Music").GetComponent<BackGroundMusic>().PlayMusic();
        gameObject.SetActive(false);
        TextManager.Intance.isChoosing = false;
        UIManager.Instance._pool = true;
    }

    public void DownBottun()
    {
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
        TextManager.Intance.isChoosing = false;
    }
}
