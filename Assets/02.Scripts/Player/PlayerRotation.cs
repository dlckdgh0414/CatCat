using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class PlayerDotween : MonoBehaviour
{
    private bool isHille;
    [SerializeField] LayerMask whatIsHille;
    [SerializeField] Transform drawLineObject;
    [SerializeField] GameObject Player;
    private float _ray = 1;
    private bool hilleHit = true;
    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Ray();
        if (isHille&&hilleHit)
        {
            hilleHit = false;
            StartCoroutine(DelayHit(0.1f));
            transform.DORotate(new Vector3(0, 0, -30), 0.5f);
            rigid.gravityScale = 10;
        }
        else
        {
            hilleHit = false;
            StartCoroutine(DelayHit(0.1f));
            transform.DORotate(new Vector3(0, 0, 0), 0.5f);
        }
    }
    private void OnDrawGizmos()
    {
        DrawRay();
    }
    private void Ray()
    {
        isHille = Physics2D.Raycast(transform.position, Vector2.down, _ray, whatIsHille);
    }

    IEnumerator DelayHit(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        hilleHit = true;
    }
    private void DrawRay()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(drawLineObject.position,drawLineObject.position+Vector3.down*2);
    }
}
