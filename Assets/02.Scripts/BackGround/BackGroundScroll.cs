using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float ScroollAmout;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector3 moveDirection;

    private void Update()
    {

        if(transform.position.x <= ScroollAmout)
        {
            transform.position = target.position - moveDirection * ScroollAmout;
        }
    }
}
