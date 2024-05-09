using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fish"))
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Trash"))
        {
            Destroy(collision.gameObject);
        }
    }
}
