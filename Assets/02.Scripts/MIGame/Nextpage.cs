using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NextPage : MonoBehaviour
{
    [SerializeField] private GameObject[] _next;
    [SerializeField] private int _count;

    public void NextButtonClik()
    {
        if (_count<=_next.Length)
        {
            StartCoroutine(Delay());
        }
    }

    public void LetsGoGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(5);
    }
    
    private IEnumerator Delay()
    {
        _next[_count].transform.DOMove(new Vector3(-25, 0, 0), 2f);
        _count += 1;
        yield return new WaitForSeconds(2f);
    }
}
