using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CatFollow : MonoBehaviour
{
    private Guge G;

    private BoxCollider2D Box;
    [SerializeField] GameObject CatFoot;

    private void Awake()
    {
        G = FindObjectOfType<Guge>();
        Box = GetComponent<BoxCollider2D>();
      
    }

    private void Update()
    {
        GetMOuseClike();
    }
    private void GetMOuseClike()
    {
        if (Input.GetMouseButton(0))
        {
            CatFoot.transform.DOMove(new Vector3(0.23f, -0.9f, 0), 1f);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            CatFoot.transform.DOMove(new Vector3(0.23f, -5.07f, 0), 1f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fish"))
        {
            Destroy(collision.gameObject);
            G.x += 0.05f;
        }
        else if (collision.gameObject.CompareTag("Trash"))
        {
            Destroy(collision.gameObject);
            G.x -= 0.03f;
        }
    }
}
