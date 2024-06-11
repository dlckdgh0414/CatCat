using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolltutorialScenes : MonoBehaviour
{
    [SerializeField] private GameObject[] _nextPolltutorial;
    private int _count = 0;

    private void Start()
    {
        _nextPolltutorial[0].SetActive(true);
        for(int i = 1; i<_nextPolltutorial.Length; i++)
        {
            _nextPolltutorial[i].SetActive(false);
        }
    }
    private void Update()
    {
       if(_count < _nextPolltutorial.Length-1)
       {
         if(Input.GetMouseButtonDown(0))
         {
            _nextPolltutorial[_count].SetActive(false);
            _count += 1;
            _nextPolltutorial[_count].SetActive(true);
         }
       }
    }

    public void Click()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
    }

}
