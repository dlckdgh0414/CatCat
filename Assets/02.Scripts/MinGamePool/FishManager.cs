using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//âȣ�� �ð���
public class FishManager : MonoBehaviour
{
    [SerializeField] private float currentTime;
    [SerializeField] private float creatTime = 2f;
    [SerializeField] private float GetFishSpawnRange;
    [SerializeField] GameObject GoldFish;
    public GameObject[] FishPrefab;

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
    private void FixedUpdate()
    {
        currentTime += Time.fixedDeltaTime;
    }
}

