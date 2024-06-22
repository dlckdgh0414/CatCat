using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCar : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float CarPower = 5f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rb.AddForce(Vector2.up * CarPower);
    }
}
