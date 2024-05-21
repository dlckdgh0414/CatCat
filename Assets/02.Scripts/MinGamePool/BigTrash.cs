using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigTrash : MonoBehaviour
{
    Rigidbody2D rigid;
    float Speed = 2f;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rigid.AddForce(Vector2.left * Speed);
    }
}
