using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldFish : MonoBehaviour
{
    Rigidbody2D rigid;
    float Power=4f;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rigid.AddForce(Vector2.left * Power);
    }
}
