using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//창호는 씹게이
public class FishManager : MonoBehaviour
{
    [SerializeField] private float currentTime;
    [SerializeField] private float creatTime = 2f;
    [SerializeField] private float GetFishSpawnRange;
    [SerializeField] GameObject GoldFish;
    public GameObject[] FishPrefab;

    Stack<GameObject> FishPool = new Stack<GameObject>();

    private void Update()
    {
        if (creatTime < currentTime)
        {
            creatTime = Random.Range(2f, 5f);
            int FishIdex = Random.Range(0, FishPrefab.Length);
            Instantiate(FishPrefab[FishIdex], transform.position, Quaternion.identity);
            currentTime = 0;
            GetFishSpawnRange = Random.Range(0, 10);
            if(GetFishSpawnRange<=2)
            {
                Instantiate(GoldFish, transform.position, Quaternion.identity);
            }
        }
    }
    private void CreatFishs()
    {
        for(int i =0; i<3; i++)
        {
            GameObject FishObj = Instantiate(FishPrefab[0]);
            FishPool.Push(FishObj);
            FishObj.SetActive(false);
        }
        for (int i = 0; i < 3; i++)
        {
            GameObject FishObj2 = Instantiate(FishPrefab[1]);
            FishPool.Push(FishObj2);
            FishObj2.SetActive(false);
        }
        for (int i = 0; i < 3; i++)
        {
            GameObject FishObj3 = Instantiate(FishPrefab[2]);
            FishPool.Push(FishObj3);
            FishObj3.SetActive(false);
        }
        for (int i = 0; i < 3; i++)
        {
            GameObject FishObj3 = Instantiate(FishPrefab[3]);
            FishPool.Push(FishObj3);
            FishObj3.SetActive(false);
        }
        for (int i = 0; i < 3; i++)
        {
            GameObject FishObj4 = Instantiate(FishPrefab[4]);
            FishPool.Push(FishObj4);
            FishObj4.SetActive(false);
        }
        for (int i = 0; i < 3; i++)
        {
            GameObject FishObj5 = Instantiate(FishPrefab[5]);
            FishPool.Push(FishObj5);
            FishObj5.SetActive(false);
        }
        for (int i = 0; i < 3; i++)
        {
            GameObject FishObj6 = Instantiate(FishPrefab[6]);
            FishPool.Push(FishObj6);
            FishObj6.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        currentTime += Time.fixedDeltaTime;
    }
}

