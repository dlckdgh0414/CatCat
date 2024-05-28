using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fish"))
        {
            FishManager.Instance.FishPool.Push(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("Trash"))
        {
            TrashSpawn.Instance.TrashPool.Push(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
        else if(collision.gameObject.CompareTag("GoldFish"))
        {
            FishManager.Instance.GoldFishPool.Push(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
        else if(collision.gameObject.CompareTag("BigTrash"))
        {
            TrashSpawn.Instance.BigTrashPool.Push(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
    }
}
