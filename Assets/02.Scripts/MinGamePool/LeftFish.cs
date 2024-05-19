using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFish : MonoBehaviour
{
    Rigidbody2D rigid;
    float Speed = 1f;
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        rigid.AddForce(Vector2.right * Speed);
    }
}
