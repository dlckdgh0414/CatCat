using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigTrash : MonoBehaviour
{
    [SerializeField] Transform finallocation;
    [SerializeField] Transform initiallocation;
    float Dist;

    private void Update()
    {
      Dist = Vector3.Distance(finallocation.position, initiallocation.position);
      
    }
}
