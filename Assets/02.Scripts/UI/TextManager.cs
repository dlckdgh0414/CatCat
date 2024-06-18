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

    public static TextManager Intance;

    private void Awake()
    {
        if(Intance == null)
        {
            Intance = this;
        }
        else
        {
            Destroy(gameObject);
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
        scanObject = scanObj;
        ObjData objData = scanObject.GetComponent<ObjData>();
        Talk(objData.Id, objData.IsNPC);
    }

    private void Talk(int id, bool isNPc)
    {
       string talkData = talkManager.GetTalk(id, talkIndex);
        if(talkData == null)
        {
            ScanObj -= ScanObjcetPlayer;
            talkIndex = 0;
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
