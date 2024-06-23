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
    [SerializeField] GameObject Hille;
    [SerializeField] GameObject towne;
    [SerializeField] GameObject CityBack;
    [SerializeField] GameObject EndingJ;
    [SerializeField] GameObject Ending;
    [SerializeField] GameObject goI;
    [SerializeField] GameObject Reset;
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
        CityBack.SetActive(false);
        EndingJ.SetActive(false);
        Ending.SetActive(false);
        goI.SetActive(false);
        Reset.SetActive(false);
    }

    public int talkIndex;

    public void Action(GameObject scanObj)
    {
            isAction = true;
            scanObject = scanObj;
            ObjData objData = scanObject.GetComponent<ObjData>();
            Talk(objData.id, objData.isNPC,objData.isChoose, objData.isPos,objData.isYesNo,objData.isClity, objData.isReChoose,objData.isHille,objData.isTown,objData.isCityBack,objData.isEndingjunction,objData.isEnding,objData.isNextHouse,objData.isBack);
        
        talkPanel.SetActive(isAction);
    }

    void Talk(int id, bool isNPC, bool isChoose, bool isPos, bool isYesNo, bool isClity, bool isReChoose, bool isHille, bool isTown, bool isCityBack,bool isEndingjunction, bool isEnding, bool isNextHouse, bool isBack)
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
            if(isHille)
            {
                isFreeze = false;
                Hille.SetActive(true);
            } 
            if(isTown)
            {
                isFreeze = false;
                towne.SetActive(true);
            }
            if(isCityBack)
            {
                isFreeze = false;
                CityBack.SetActive(true);
            }
            if(isEndingjunction)
            {
                isFreeze = false;
                EndingJ.SetActive(true);
            } 
            if(isEnding)
            {
                isFreeze = false;
                Ending.SetActive(true);
            }
            if(isEnding)
            {
                isFreeze = false;
                goI.SetActive(true);
            }
            if(isEnding)
            {
                isFreeze = false;
                Reset.SetActive(true);
            }

            talkIndex = 0; //대화가 끝날 때 0으로 초기화 , 다른 사물하고도 계속 대화를 진행 하기 위함.
            isAction = false;
            return;  // 끝 , void 함수에서 return은 강제 종료 역할.
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
