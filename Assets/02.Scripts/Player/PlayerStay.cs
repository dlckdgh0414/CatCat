using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStay : MonoBehaviour
{
    Animator anim;
    float StayTime;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        StayTime+=Time.fixedDeltaTime;
    }
}
