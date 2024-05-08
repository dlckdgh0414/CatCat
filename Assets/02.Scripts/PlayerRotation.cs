using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerDotween : MonoBehaviour
{
    RaycastHit2D Hille;
    private bool HilleHit=true;
    [SerializeField] Transform drawLineObject;
    [SerializeField] GameObject Player;
    Rigidbody2D rigid;
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Ray();
    }
    private void OnDrawGizmos()
    {
        DrawRay();
    }
    private void Ray()
    {
        Hille = Physics2D.Raycast(rigid.position, Vector3.down, 3f, 1 << 3);
        if(HilleHit)
        {
            if (Hille.collider.gameObject.tag == "Buttom")
            {
                HilleHit = false;
                StartCoroutine(DelayHit(0.1f));
                Player.transform.DORotate(new Vector3(0, 0, -30), 1f);
                rigid.gravityScale = 1.5f;

            }
            else
            {
                HilleHit = false;
                StartCoroutine(DelayHit(0.01f));
                Player.transform.DORotate(new Vector3(0, 0, 0), 0.2f);
            }
        }
    }
    IEnumerator DelayHit(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        HilleHit = true;
    }
    private void DrawRay()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(drawLineObject.position,drawLineObject.position+Vector3.down*2);
    }
}
