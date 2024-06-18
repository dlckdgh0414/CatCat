using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class RightFish : MonoBehaviour
{
    Rigidbody2D rigid;
    float Speed = 1f;
    Transform final;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        final = GameObject.FindGameObjectWithTag("Final").transform;
    }

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOMove(final.position, Speed).SetEase(Ease.Linear));
        sequence.AppendCallback(IntoPool);
    }

    private void IntoPool()
    {
        FishManager.Instance.FishPool.Push(gameObject);
        gameObject.SetActive(false);
    }

    private void Update()
    {
        //rigid.AddForce(Vector2.left * Speed);
        //if(transform.position.x >= 11.41f && transform.position.y >= 4.89f)
        //{
        //    rigid.AddForce(Vector2.left * Speed);
        //    rigid.AddForce(Vector2.down * Speed);
        //}

        //if(transform.position.x )

    }
}