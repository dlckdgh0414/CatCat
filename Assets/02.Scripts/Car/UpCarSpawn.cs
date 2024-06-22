using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCarSpawn : MonoBehaviour
{
    [SerializeField] GameObject CarPrefab;
    public Stack<GameObject> CarPool = new Stack<GameObject>();
    [SerializeField] private float creatTime;
    [SerializeField] private float currentTime;

    public static UpCarSpawn Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

    }

    private void Start()
    {    
            CreatCar();
    }
    private void Update()
    {
        if (creatTime < currentTime)
        {
            creatTime = Random.Range(2f, 8f);
            GameObject TrashObj;
            if (CarPool.Count > 0)
            {
                TrashObj = CarPool.Pop();
                TrashObj.SetActive(true);

            }
            else
            {
                TrashObj = Instantiate(CarPrefab);

            }
            TrashObj.transform.position = transform.position;
            currentTime = 0;
        }
    }

    private void CreatCar()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject CarObj = Instantiate(CarPrefab);
            CarPool.Push(CarObj);
            CarObj.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        currentTime += Time.fixedDeltaTime;
    }
}
