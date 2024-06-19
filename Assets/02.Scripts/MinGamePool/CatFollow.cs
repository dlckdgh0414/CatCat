using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CatFollow : MonoBehaviour
{
    private Guge G;

    private BoxCollider2D Box;
    [SerializeField] GameObject CatFoot;
    private bool isStun;
    private float desiredAngle;

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
        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //desiredAngle = Mathf.Atan2(mousePos.x, mousePos.y) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(-desiredAngle, Vector3.forward);
        bool canMove = false;

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotDir = (Vector3)mousePos - transform.position;
        float rotation = Mathf.Atan2(rotDir.y, rotDir.x) * Mathf.Rad2Deg;

        if (rotation < 0 && !canMove)
            transform.rotation = Quaternion.AngleAxis(rotation - 135, Vector3.forward);

        if (Input.GetMouseButtonDown(0) && !canMove)
        {
            canMove = true;
            CatFoot.transform.DOMove(new Vector3(mousePos.x, mousePos.y,0), 0.5f);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            
            CatFoot.transform.DOMove(new Vector3(0.35f, 5.57f, 0), 0.5f);
            canMove = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fish"))
        {
            FishManager.Instance.FishPool.Push(collision.gameObject);
            LeftManager.Intacne.FishPool.Push(collision.gameObject);
            collision.gameObject.SetActive(false);
            G.x += 0.05f;
        }
        else if (collision.gameObject.CompareTag("Trash"))
        {
            TrashSpawn.Instance.TrashPool.Push(collision.gameObject);
            collision.gameObject.SetActive(false);
            G.x -= 0.03f;
        }
        else if (collision.gameObject.CompareTag("GoldFish"))
        {
            FishManager.Instance.GoldFishPool.Push(collision.gameObject);
            collision.gameObject.SetActive(false);
            G.x += 0.4f;
        }
        else if (collision.gameObject.CompareTag("BigTrash"))
        {
            TrashSpawn.Instance.BigTrashPool.Push(collision.gameObject);
            collision.gameObject.SetActive(false);
            G.x -= 0.3f;
        }
    }
}