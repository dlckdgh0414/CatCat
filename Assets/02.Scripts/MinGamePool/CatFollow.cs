using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFollow : MonoBehaviour
{
    private Guge G;

    private BoxCollider2D Box;

    private void Awake()
    {
        Vector2 mousePos = Input.mousePosition;
        G = FindObjectOfType<Guge>();
        Box = GetComponent<BoxCollider2D>();
      
    }
    private void Update()
    {
        Mouse();
        GetMousClik();
    }

    private void Mouse()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, mousePos.y, 0);
    }

    private void GetMousClik()
    {
        if(Input.GetMouseButton(0))
        {
            Box.isTrigger = false;
        }
        else
        {
            Box.isTrigger = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fish"))
        {
            Destroy(collision.gameObject);
            G.x += 0.05f;
        }
        else if(collision.gameObject.CompareTag("Trash"))
        {
            Destroy(collision.gameObject);
            G.x -= 0.03f;
        }
    }
}
