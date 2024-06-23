using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCollder : MonoBehaviour
{
    BoxCollider2D box;

    private void Awake()
    {
        box = GetComponent<BoxCollider2D>();
    }
    public void OffTrigger()
    {
        box.isTrigger = false;
    }
}
