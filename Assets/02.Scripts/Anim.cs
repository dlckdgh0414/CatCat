using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    Animator anim;
    private readonly int walkHash = Animator.StringToHash("Walk");
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
}
