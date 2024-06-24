using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRub : MonoBehaviour
{
    Animator anim;
    PlayerMove player;
    public bool isRun;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        player = GetComponent<PlayerMove>();
    }
    void Update()
    {
        PlayerRun();
    }

    private void PlayerRun()
    {
        if (Input.GetKey(KeyCode.LeftShift) && TextManager.Intance.isFreeze && player.catMove)
        {
            player.speed = 13.5f;
            anim.SetBool("Run", true);
            isRun = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift) && TextManager.Intance.isFreeze)
        {
            player.speed = 5f;
            anim.SetBool("Run", false);
            isRun = false;
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(2f);
    }
}
