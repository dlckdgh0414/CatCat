using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    private Animator _anim;
    private bool isOn = false;
    [SerializeField] GameObject fkey;


    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        fkey.SetActive(true);
            if(Input.GetKeyDown(KeyCode.Alpha1) && !isOn)
            {
                Debug.Log("µÇ³ª");
                _anim.SetBool("ON", true);
                isOn = true;
            }
            else if(Input.GetMouseButtonDown(0) && isOn)
            {
                _anim.SetBool("ON", false);
            }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        fkey.SetActive(false);
    }
}
