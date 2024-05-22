using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftManager : MonoBehaviour
{
   [SerializeField]private float currentTime;
   [SerializeField] private float creatTime = 2f;
    public GameObject[] FishPrefab;

    Stack<GameObject> FishPool = new Stack<GameObject>();

    private void Start()
    {      
         for (int i = 0; i < 7; i++)
         {
              CreatFishs(i);
         }        
    }
    private void Update()
    {
        if(creatTime<currentTime)
        {
            creatTime = Random.Range(2f, 5f);
            int FishIdex = Random.Range(0, FishPrefab.Length);
            Instantiate(FishPrefab[FishIdex], transform.position, Quaternion.identity);
            currentTime = 0;
        }
    }
    public void CreatFishs(int n)
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject FishObj = Instantiate(FishPrefab[n]);
            FishPool.Push(FishObj);
            FishObj.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        currentTime +=Time.fixedDeltaTime;
    }
}
