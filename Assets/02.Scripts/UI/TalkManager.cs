using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    //[SerializeField] private TextDataListSO textDataListSO;
    Dictionary<int, string[]> talkData;

    public static TalkManager Inatnce;

    private void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        if (Inatnce == null)
        {
            Inatnce = this;
        }
        else
            Destroy(gameObject);

        GenerateData();
    }

    private void GenerateData()
    {
        talkData.Add(0, new string[] { "���� ��ġ��" });
        talkData.Add(1, new string[] { "��û ū ���̴�.","�������� ������ �� ���� �� ����.","�ƽ��� ��" });
        talkData.Add(2, new string[] { "����̰� ���ְ� �԰� ���� �� �����̴�.", "����̴� �谡 �θ��Ű���.", "���� ���� ����?" });
        talkData.Add(3, new string[] { "����̴� ���� �谡 �ſ� ���°Ű���.","�������� ����Ⱑ �����Ű���.","�츮�� ����̸� ���� ����⸦ ����ٱ��?" });
        talkData.Add(4, new string[] { "������ ���� �������ڿ� ���ô밡 �ִ�.", "�� ������ ����Ⱑ ������ �����Ű���.", });
        talkData.Add(5, new string[] { "����̰� �谡 ������ �񸻶��մϴ�.", "��ħ �������� �ֳ׿�", "ǥ���ǿ��� �������� ��å�ζ�� �����ֽ��ϴ�.", "���� ���°� �������?" });
        talkData.Add(6, new string[] { "����̴� ���� �踦 ä���� ���߽��ϴ�. �׷��� ���ư��� �ǰ���?" });
    }


    //public string GetTalk(int id, int talkIndex)
    //{
    //    Debug.Log(talkIndex);
    //    Debug.Log(textDataListSO.list[id].text.Count);
    //    if (talkIndex <= textDataListSO.list.Count)
    //    {
    //        return textDataListSO.list[id].text[talkIndex];
    //    }
    //    return "NULL";
    //}

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }

    private void OnEnable()
    {
        DontDestroyOnLoad(gameObject);
    }
}
