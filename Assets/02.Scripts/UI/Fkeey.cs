using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fkeey : MonoBehaviour
{
    [SerializeField] GameObject fkey;

    private void Awake()
    {
        fkey.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        fkey.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        fkey.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        fkey.SetActive(true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        fkey.SetActive(false);
    }
}
