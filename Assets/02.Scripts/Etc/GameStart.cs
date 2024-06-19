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

    private void Update()
    {
        _anim.SetBool("Walk", true);
        transform.DOMoveX(417,3f).SetEase(Ease.Linear);

        
       
    }
}
