using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    RaycastHit2D hit;
    int Distance = 2;
    Rigidbody2D rigid;
    [SerializeField] private LayerMask whatIsBottom;
    private Animator anim;
    PlayerMove player;
    //창호는 씹게이
    private bool canHit = true;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        player = GetComponent<PlayerMove>();

    }
    private void Update()
    {
        Ray();
    }

    private void Ray()
    {
        Debug.DrawRay(rigid.position, Vector3.down, new Color(0, 1, 0), 0.3f);
        hit = Physics2D.Raycast(rigid.position, Vector3.down, 3f, 1 << 3);

        if (canHit)
        {
            if (hit.collider == null) return;
            Debug.Log(hit.collider.name);
            if (hit.collider.gameObject.tag == "Buttom")
            {
                canHit = false;
                StartCoroutine(DelayHit(0.1f));
                transform.rotation = Quaternion.Euler(0, 0, -40);
                rigid.gravityScale = 1.5f;
                anim.SetBool("HileRun", true);

            }
            else
            {
                canHit = false;
                StartCoroutine(DelayHit(0.01f));
                rigid.gravityScale = 5f;
                transform.rotation = Quaternion.Euler(0, 0, 0);
                anim.SetBool("HileRun", false);
                //창호는 씹게이
            }
        }
    }

     IEnumerator DelayHit(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        canHit = true;
    }
}
