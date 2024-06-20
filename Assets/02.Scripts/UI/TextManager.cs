using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class TextManager : MonoBehaviour
{
    [SerializeField] TalkManager talkManager;
    [SerializeField] GameObject talkPanel;
    [SerializeField] TextEffect TalkEffect;
    [SerializeField] GameObject scanObject;
    [SerializeField] GameObject Choose;
    public bool isAction { get; private set; }
    public GameObject TalkPanel
    {
        get => talkPanel;
        set => talkPanel = value;
    }

    public static TextManager Intance;
    
    private void Awake()
    {
        if (Intance == null)
        {
            Intance = this;
        }
        else
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        Choose.SetActive(true);
    }

    public int talkIndex;

    public void Action(GameObject scanObj)
    {
            isAction = true;
            scanObject = scanObj;
            ObjData objData = scanObject.GetComponent<ObjData>();
            Talk(objData.id, objData.isNPC,objData.isChoose);
        
        talkPanel.SetActive(isAction);
    }

    void Talk(int id, bool isNPC, bool isChoose)
    {
        string talkData = talkManager.GetTalk(id, talkIndex);

        if (talkData == null)
        {
            talkIndex = 0; //��ȭ�� ���� �� 0���� �ʱ�ȭ , �ٸ� �繰�ϰ� ��� ��ȭ�� ���� �ϱ� ����.
            isAction = false;
            return;  // �� , void �Լ����� return�� ���� ���� ����.
        }

        if(isChoose)
        {
            if(talkData == null)
            {

            }
                
        }

        if (isNPC)
        {
            TalkEffect.SetMsg(talkData.Split(':')[0]);
        }

        else
        {
            TalkEffect.SetMsg(talkData);
        }
        isAction = true;
        talkIndex++;
    }

    private void OnEnable()
    {
        
    }
}
