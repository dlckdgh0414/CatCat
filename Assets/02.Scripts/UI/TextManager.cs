using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class TextManager : MonoBehaviour
{
    public TalkManager talkManager;
    public GameObject talkPanel;
    public TextMeshProUGUI TalkText;
    public GameObject scanObject;
    public bool isAction;

    public int talkIndex;

    public void Action(GameObject getObjcet)
    {
        if (isAction)
        {
            isAction = false;
            talkPanel.SetActive(false);
        }
        else
        {

            isAction = true;
            scanObject = getObjcet;
            TalkText.text = "�̰��� �̸��� " + scanObject.name + " �̶�� �Ѵ�";
        }
        talkPanel.SetActive(isAction);

        ObjData objData = scanObject.GetComponent<ObjData>();
        Talk(objData.id, objData.isNPC);


        talkPanel.SetActive(isAction);   // isAction == false , ���� Ul â �ݰڴ�.
    }

    void Talk(int id, bool isNPC)
    {
        string talkData = talkManager.GetTalk(id, talkIndex);

        if (talkData == null)
        {
            isAction = false;
            talkIndex = 0; //��ȭ�� ���� �� 0���� �ʱ�ȭ , �ٸ� �繰�ϰ� ��� ��ȭ�� ���� �ϱ� ����.
            return;  // �� , void �Լ����� return�� ���� ���� ����.
        }

        if (isNPC)
        {
            TalkText.text = talkData;
        }

        else
        {
            TalkText.text = talkData;
        }

        isAction = true;
        talkIndex++;
    }
}
