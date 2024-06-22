using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryCar : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Car"))
        {
            CarSpawn.Instance.CarPool.Push(gameObject);
            UpCarSpawn.Instance.CarPool.Push(gameObject);
        }
    }
}
