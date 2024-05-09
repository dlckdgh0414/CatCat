using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rigid;
    public float speed = 5f;
    Animator anim;
    SpriteRenderer sprit;
    private readonly int walkHash = Animator.StringToHash("Walk");
    public Vector2 move;
    public bool catMove = true;
    public float x;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        sprit = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }
    void FixedUpdate()
    {
            Move();
        
    }

    private void Move()
    {
        x = Input.GetAxisRaw("Horizontal");

        move = new Vector2(x * speed, rigid.velocity.y);
        rigid.velocity = move;
        anim.SetBool(walkHash, move.magnitude > 0);
        if (move.x > 0)
        {
            
            sprit.flipX = false;
        }
        else if (move.x < 0)
        {
            
            sprit.flipX = true;
        }
    }
}
