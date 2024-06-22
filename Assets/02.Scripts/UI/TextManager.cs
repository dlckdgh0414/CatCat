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
    [SerializeField] GameObject CityUi;
    [SerializeField] GameObject reChoose;
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
        CityUi.SetActive(false);
        reChoose.SetActive(false);
    }

    public int talkIndex;

    public void Action(GameObject scanObj)
    {
            isAction = true;
            scanObject = scanObj;
            ObjData objData = scanObject.GetComponent<ObjData>();
            Talk(objData.id, objData.isNPC,objData.isChoose, objData.isPos,objData.isYesNo,objData.isClity, objData.isReChoose);
        
        talkPanel.SetActive(isAction);
    }

    void Talk(int id, bool isNPC, bool isChoose, bool isPos, bool isYesNo, bool isClity, bool isReChoose)
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
            if(isClity)
            {
                isFreeze = false;
                CityUi.SetActive(true);
            }  
            if(isReChoose)
            {
                isFreeze = false;
                reChoose.SetActive(true);
            }

            talkIndex = 0; //��ȭ�� ���� �� 0���� �ʱ�ȭ , �ٸ� �繰�ϰ��� ��� ��ȭ�� ���� �ϱ� ����.
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