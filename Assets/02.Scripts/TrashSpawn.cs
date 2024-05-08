using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] Trash;
    [SerializeField] private float currentTime;
    [SerializeField] private float creatTime = 4.5f;
    private void Update()
    {
        if (creatTime<currentTime)
        { 
            int TrashIdex = Random.Range(0, Trash.Length);
            Instantiate(Trash[TrashIdex], transform.position, Quaternion.identity);
            currentTime = 0;
        }
       
    }
    private void FixedUpdate()
    {
        currentTime += Time.fixedDeltaTime;
    }
}
