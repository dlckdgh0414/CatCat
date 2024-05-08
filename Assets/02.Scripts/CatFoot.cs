using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CatFoot : MonoBehaviour
{
    [SerializeField] private GameObject catFoot;
    [SerializeField] private GameObject UI;
    [SerializeField] private GameObject UI1;
    [SerializeField] private GameObject UI2;
    [SerializeField] private GameObject UI3;
    [SerializeField]int Count;

    public void StartClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(5);
    }

    public void OnClick()
    {
        StartCoroutine(catMove());
    }
    IEnumerator catMove()
    {
        catFoot.transform.DOMove(new Vector3(-9f, 0, 0), 1f);
        yield return new WaitForSeconds(1.5f);
        catFoot.transform.DOMove(new Vector3(-20, 0, 0), 1f);
        switch(Count)
        {
            case 0:
                UI.transform.DOMove(new Vector3(-25, 0, 0), 1f);
                ++Count;
                break;
            case 1:
                UI1.transform.DOMove(new Vector3(-25, 0, 0), 1f);
                ++Count;
                break;
            case 2:
                UI2.transform.DOMove(new Vector3(-25, 0, 0), 1f);
                ++Count;
                break;
            case 3:
                UI3.transform.DOMove(new Vector3(-25, 0, 0), 1f);
                break;
        }
    }
}
