using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRub : MonoBehaviour
{
    Animator anim;
    PlayerMove player;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        player = GetComponent<PlayerMove>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && TextManager.Intance.isFreeze)
        {
            player.speed += 5f;
            anim.SetBool("Run", true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift) && TextManager.Intance.isFreeze)
        {
            player.speed = 5f;
            anim.SetBool("Run", false);
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(2f);
    }
}
