using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolltutorialScenes : MonoBehaviour
{
    [SerializeField] private GameObject[] _nextPolltutorial;
    private int _count = 0;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _nextPolltutorial[_count].SetActive(false);
            _count += 1;
        }
    }

}
