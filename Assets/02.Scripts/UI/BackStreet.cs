using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackStreet : MonoBehaviour
{

    [SerializeField] GameObject Playerpos;

    private void Start()
    {
        Playerpos = GameObject.Find("Player");
    }

    public void B(int ScenName)
    {
        GameManager.Instance.Player.SetActive(true);
        UnityEngine.SceneManagement.SceneManager.LoadScene(ScenName);

    }
}
