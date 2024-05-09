using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashLeft : MonoBehaviour
{
    Rigidbody2D rigid;
    private float Power = 0.5f;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rigid.AddForce(Vector2.right * Power);
    }
}
