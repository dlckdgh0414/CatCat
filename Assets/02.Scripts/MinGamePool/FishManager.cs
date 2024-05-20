using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//창호는 씹게이
public class FishManager : MonoBehaviour
{
    public static FishManager Instance;

    [SerializeField] private float currentTime;
    [SerializeField] private float creatTime = 2f;
    [SerializeField] private float GetFishSpawnRange;
    [SerializeField] GameObject GoldFish;
    public GameObject[] FishPrefab;

   public Stack<GameObject> FishPool = new Stack<GameObject>();

    private void Awake()
    {
        if(Instance==null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
            
    }

    private void Start()
    {
        for (int i = 0; i < 7; i++)
        {
            CreatFishs(i);
        }
    }
    private void Update()
    {
        if (creatTime < currentTime)
        {
            creatTime = Random.Range(2f, 5f);
            int FishIdex = Random.Range(0, FishPrefab.Length);
            GameObject FishObj;
            if(FishPool.Count>0)
            {
                FishObj = FishPool.Pop();
                FishObj.SetActive(true);
            }
            else
            {
                FishObj = Instantiate(FishPrefab[FishIdex]);
            }
            FishObj.transform.position = transform.position;
            currentTime = 0;
            GetFishSpawnRange = Random.Range(0, 10);
            if(GetFishSpawnRange<=2)
            {
                Instantiate(GoldFish, transform.position, Quaternion.identity);
            }
        }
    }
    public void CreatFishs(int n)
    {
        for(int i =0; i<3; i++)
        {
            GameObject FishObj = Instantiate(FishPrefab[n]);
            FishPool.Push(FishObj);
            FishObj.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        currentTime += Time.fixedDeltaTime;
    }
}

