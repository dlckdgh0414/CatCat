using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class TextManager : MonoBehaviour
{
    [SerializeField] TalkManager talkManager;
    [SerializeField] private TextMeshProUGUI talkText;
    [SerializeField] private GameObject scanObject;
    public Action<GameObject> ScanObj;
    public int talkIndex;
    public bool IsTalking { get; private set; }

    public static TextManager Intance;

    private void Awake()
    {
        if(Intance == null)
        {
            Intance = this;
        }
        gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        ScanObj += ScanObjcetPlayer;
    }

    private void OnDisable()
    {
        ScanObj -= ScanObjcetPlayer;
    }

    public void ScanObjcetPlayer(GameObject scanObj)
    {
        IsTalking = true;
        scanObject = scanObj;
        ObjData objData = scanObject.GetComponent<ObjData>();
        Talk(objData.Id, objData.IsNPC);
    }

    private void Talk(int id, bool isNPc)
    {
       string talkData = talkManager.GetTalk(id, talkIndex);
        Debug.Log(talkData);
        if(talkData == "NULL")
        {
            Debug.Log("aaaa");
            IsTalking = false;
            talkIndex = 0;
            ScanObj -= ScanObjcetPlayer;
            return;
        }
        if(isNPc)
        {
            talkText.text = talkData;
        }
        else
        {
            talkText.text = talkData;
        }

        talkIndex++;
    }
}
