using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirgger : MonoBehaviour
{
    public bool _pool;
    [SerializeField] GameObject Playerpos;

    public static Tirgger Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
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
    public void YesClik()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        Playerpos.transform.position = new Vector2(70.79f, -12.8f);
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("Music").GetComponent<BackGroundMusic>().PlayMusic();
        if(_pool)
        {
            GameObject.FindGameObjectWithTag("Music2").GetComponent<BackGround2>().StopMusic();
        }
        TextManager.Intance.isChoosing = false;
    }

    public void No()
    {
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
        TextManager.Intance.isChoosing = false;
    }
}
