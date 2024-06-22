using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirgger : MonoBehaviour
{
    public bool _pool;
    [SerializeField] GameObject Playerpos;
    private void Start()
    {
        Playerpos = GameObject.Find("Player");
    }
    public void YesClik()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        Playerpos.transform.position = new Vector2(57.7F, -21.3f);
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("Music2").GetComponent<BackGround2>().StopMusic();
    }

    public void No()
    {
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);
    }
}
