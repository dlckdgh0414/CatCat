using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcroosSinge : MonoBehaviour
{
    public bool isOn;
    Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(OnDelayTime());
    }
    private IEnumerator OnDelayTime()
    {
        while(true)
        {
            yield return new WaitForSeconds(20f);
            _anim.SetBool("Onoff", true);
            isOn = true;
            yield return new WaitForSeconds(32f);
            _anim.SetBool("Onoff", false);
            isOn = false;
            continue;
        }
        
    }
}
