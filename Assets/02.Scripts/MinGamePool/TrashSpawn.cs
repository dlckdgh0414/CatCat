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

    private void Update()
    {
        if (creatTime<currentTime)
        {
            creatTime = Random.Range(2f, 5f);
            int TrashIdex = Random.Range(0, Trash.Length);
            Instantiate(Trash[TrashIdex], transform.position, Quaternion.identity);
            currentTime = 0;
            BigTrashSpawnRange = Random.Range(0, 10);
            if(BigTrashSpawnRange<=4)
            {
                Instantiate(BigTrash, transform.position, Quaternion.identity);
            }
        }
       
    }

    private void CreatTrash()
    {

    }

    private void FixedUpdate()
    {
        currentTime += Time.fixedDeltaTime;
    }
}
