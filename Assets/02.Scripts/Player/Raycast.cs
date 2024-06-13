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
    [SerializeField] private GameObject _take;

    private void Start()
    {
        _take.SetActive(false);
    }

    private void OnDrawGizmos()
    {
        gizmo();
    }

    private void Update()
    {
        CheackHuman();
        if(isHuman)
        {
            _take.SetActive(true);
        }
        else if(!isHuman)
        {
            _take.SetActive(false);
        }
    }
    private void CheackHuman()
    {
        RaycastHit2D raayHit = Physics2D.Raycast(transform.position, Vector3.right , ray, whatisHuman);
        RaycastHit2D rayHit = Physics2D.Raycast(transform.position, Vector3.left, ray, whatisHuman);
    }

    private void FixedUpdate()
    {
       
    }

    private void gizmo()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * ray);
    }
}
