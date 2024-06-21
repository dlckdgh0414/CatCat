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
    [SerializeField] GameObject ChoosePoolPath;
    [SerializeField] GameObject Choose;
    [SerializeField] GameObject YesOrNochoose;
    public bool isAction { get; private set; }
    public bool isFreeze {  get;  set; }
    public GameObject TalkPanel
    {
        get => talkPanel;
        set => talkPanel = value;
    }

    public static TextManager Intance;
    
    private void Start()
    {
        if (Intance == null)
        {
            Intance = this;
        }
        else
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        isFreeze = true;
        Choose.SetActive(false);
        ChoosePoolPath.SetActive(false);
        YesOrNochoose.SetActive(false);
    }

    public int talkIndex;

    public void Action(GameObject scanObj)
    {
            isAction = true;
            scanObject = scanObj;
            ObjData objData = scanObject.GetComponent<ObjData>();
            Talk(objData.id, objData.isNPC,objData.isChoose, objData.isPos,objData.isYesNo);
        
        talkPanel.SetActive(isAction);
    }

    void Talk(int id, bool isNPC, bool isChoose, bool isPos, bool isYesNo)
    {
        string talkData = talkManager.GetTalk(id, talkIndex);

        if (talkData == null)
        {
            if (isChoose)
            {
                isFreeze = false;
                Choose.SetActive(true);
            }
            if(isPos)
            {
                isFreeze = false;
                ChoosePoolPath.SetActive(true);
            }
            if (isYesNo)
            {
                isFreeze = false;
                YesOrNochoose.SetActive(true);
            }

            talkIndex = 0; //��ȭ�� ���� �� 0���� �ʱ�ȭ , �ٸ� �繰�ϰ� ��� ��ȭ�� ���� �ϱ� ����.
            isAction = false;
            return;  // �� , void �Լ����� return�� ���� ���� ����.
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
}
