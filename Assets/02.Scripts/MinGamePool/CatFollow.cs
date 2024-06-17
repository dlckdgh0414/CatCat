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
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        CatFoot.transform.DORotate(new Vector3(5.27f, 0,135.33f + mousePos.z), 0.5f);
        if (Input.GetMouseButton(0))
        {
            CatFoot.transform.DORotate(new Vector3(5.27f, 0, 135.33f + mousePos.z), 0.5f);
            CatFoot.transform.DOMove(new Vector3(0.35f, 5.57f,0), 0.5f);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            
            CatFoot.transform.DOMove(new Vector3(0.35f,mousePos.y, 0), 0.5f);
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
            G.trashx -= 0.3f;
        }
    }
}