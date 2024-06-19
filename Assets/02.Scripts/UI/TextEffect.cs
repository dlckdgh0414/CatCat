using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextEffect : MonoBehaviour
{
    [SerializeField] private string _targetMsg;
    [SerializeField] private int CharPerSceonds;
    [SerializeField] GameObject EndCursor;
    TextMeshProUGUI _text;
    int index;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    public void SetMsg(string msg)
    {
        _targetMsg = msg;
        EffectStart();
    }

    private void EffectStart()
    {
        _text.text = "";
        index = 0;
        EndCursor.SetActive(false);

        Invoke("Effecting", 1/ CharPerSceonds);
    } 
    private void Effecting()
    {
        if(_text.text == _targetMsg)
        {
            EffectEnd();
            return;
        }
        _text.text += _targetMsg[index];
        index++;
        Invoke("Effectiong", 1 / CharPerSceonds);
    } 
    private void EffectEnd()
    {
        EndCursor.SetActive(true);
    }
}
