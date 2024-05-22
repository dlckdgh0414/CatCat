using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] Trash;
    [SerializeField] private GameObject BigTrash;
    [SerializeField] private float BigTrashSpawnRange; 
    [SerializeField] private float currentTime;
    [SerializeField] private float creatTime = 4.5f;

    Stack<GameObject> TrashPool = new Stack<GameObject>();
    Stack<GameObject> BigTrashPool = new Stack<GameObject>();

    GameObject TrashObj;
    GameObject BigTrashObj;

    private void Start()
    {
        for (int i = 0; i <2; i++)
        {
            CreatTrash(i);
        }
    }

    private void Update()
    {
        if (creatTime<currentTime)
        {
            creatTime = Random.Range(2f, 5f);
            int TrashIdex = Random.Range(0, Trash.Length);
            GameObject TrashObj;
            if (TrashPool.Count>0)
            {
               TrashObj = TrashPool.Pop();
               TrashObj.SetActive(true);

            }
            else
            {
                Instantiate(Trash[TrashIdex]);

            }
            TrashObj.transform.position = transform.position;
            currentTime = 0;
            BigTrashSpawnRange = Random.Range(0, 10);
            if(BigTrashSpawnRange<=4)
            {
                if(BigTrashPool.Count>0)
                {
                    BigTrashObj = BigTrashPool.Pop();
                    BigTrashObj.SetActive(true);
                }
                else
                {
                    Instantiate(BigTrash);
                }
                BigTrashObj.transform.position = transform.position;
            }
        }
       
    }

    private void CreatTrash(int n)
    {
        for(int i = 0; i<3; i++)
        {
            GameObject TrashObj = Instantiate(Trash[n]);
            TrashPool.Push(TrashObj);
            TrashObj.SetActive(false);
        }
        for(int i = 0; i<3; i++)
        {
            GameObject BigTrashObj = Instantiate(BigTrash);
            BigTrashPool.Push(BigTrashObj);
            BigTrash.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        currentTime += Time.fixedDeltaTime;
    }
}
