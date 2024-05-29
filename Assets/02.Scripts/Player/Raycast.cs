using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private bool isHuman = false;
    [SerializeField] private LayerMask whatisHuman;
    private float ray = 0.7f;

    private void OnDrawGizmos()
    {
        gizmo();
    }

    private void Update()
    {
        CheackHuman();
        if(isHuman)
        {
            Debug.Log("°¨ÁöÇÔ");
        }
    }
    private void CheackHuman()
    {
        isHuman = Physics2D.Raycast(transform.position, Vector3.right , ray, whatisHuman);
    }

    private void gizmo()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * ray);
    }
}
