using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//창호는 씹게이
public class FishManager : MonoBehaviour
{
    [SerializeField] private float currentTime;
    [SerializeField] private float creatTime = 2f;
    public GameObject[] FishPrefab;

    private void Update()
    {
        if (creatTime < currentTime)
        {
            int FishIdex = Random.Range(0, FishPrefab.Length);
            Instantiate(FishPrefab[FishIdex], transform.position, Quaternion.identity);
            currentTime = 0;
        }
    }
    private void FixedUpdate()
    {
        currentTime += Time.fixedDeltaTime;
    }
}

