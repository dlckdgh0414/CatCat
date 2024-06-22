using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] CarPrefab;
    Stack<GameObject> CarPool = new Stack<GameObject>();
   [SerializeField] private float creatTime;
    [SerializeField] private float currentTime;

    private void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            CreatCar(i);
        }
    }
    private void Update()
    {
        if (creatTime < currentTime)
        {
            creatTime = Random.Range(2f, 5f);
            int TrashIdex = Random.Range(0, CarPrefab.Length);
            GameObject TrashObj;
            if (CarPool.Count > 0)
            {
                TrashObj = CarPool.Pop();
                TrashObj.SetActive(true);

            }
            else
            {
                TrashObj = Instantiate(CarPrefab[TrashIdex]);

            }
            TrashObj.transform.position = transform.position;
            currentTime = 0;
        }
    }

        private void CreatCar(int n)
        {
        for (int i = 0; i < 3; i++)
        {
            GameObject CarObj = Instantiate(CarPrefab[n]);
            CarPool.Push(CarObj);
            CarObj.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        currentTime += Time.fixedDeltaTime;
    }
}
