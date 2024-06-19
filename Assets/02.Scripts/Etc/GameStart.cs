using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameStart : MonoBehaviour
{
    Rigidbody2D _rigid;
    Animator _anim;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    private void Start()
    {
        _anim.SetBool("Walk", true);
        transform.DOMoveX(417, 3f).SetEase(Ease.Linear);
    }

    private void Update()
    {

        if(transform.position.x >= 404)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.DOMoveX(-424, 3f).SetEase(Ease.Linear);
        }
        if(transform.position.x >= -424)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.DOMoveX(417, 3f).SetEase(Ease.Linear);
        }     
    }
}
