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
    public bool catMove;
    public float x;
    

   public static PlayerMove Intance;

    private void Awake()
    {
        if(Intance == null)
        {
            Intance = this;
        }
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        sprit = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        if(!TextManager.Intance.isAction &&  TextManager.Intance.isFreeze)
        {
            Move();
        }
       
    }

    public void Move()
    {
        x = Input.GetAxisRaw("Horizontal");

        move = new Vector2(x * speed, rigid.velocity.y);
        rigid.velocity = move;

        anim.SetFloat(walkHash, move.magnitude);

        if(move.magnitude > 0)
        {
            catMove = true;
        }
        else if(move.magnitude == 0)
        {
            catMove = false;
        }

        if(move.x<0)
        {
            sprit.flipX = true;
        }
        else if(move.x>0)
        {
            sprit.flipX = false;
        }
    }
}
