using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CatFoot : MonoBehaviour
{
    [SerializeField] private GameObject catFoot;
    [SerializeField] private GameObject UI;
    [SerializeField] private GameObject UI1;
    [SerializeField]int Count;


    public void OnClick()
    {
        StartCoroutine(catMove());
    }
    IEnumerator catMove()
    {
        catFoot.transform.DOMove(new Vector3(-9f, 0, 0), 1f);
        yield return new WaitForSeconds(1.5f);
        catFoot.transform.DOMove(new Vector3(-20, 0, 0), 1f);
        if (Count == 0)
        {
            UI.transform.DOMove(new Vector3(-25, 0, 0), 1f);
            Count++;
        }
        else
        {
            UI1.transform.DOMove(new Vector3(-25, 0, 0), 1f);
        }
    }
}
