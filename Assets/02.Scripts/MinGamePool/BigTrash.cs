using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigTrash : MonoBehaviour
{
    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
}
