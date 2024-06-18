using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
   private Dictionary<int, string[]> talkData;

    private void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    private void GenerateData()
    {
        talkData.Add(100, new string[] {"���� ǥ�����̴�.", "ǥ���ǿ� ũ�� ���ڰ� �����ִ°Ű���.", "Ȯ���غ���?" });
        talkData.Add(200, new string[] {"���� �Ҿƹ����� ���ڿ��� �� �ִ�.", "�ѹ� �ٰ��� ����?"});
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
        {
            return null;
            talkIndex = 0;
        }

        else
         return talkData[id][talkIndex];
    }
}
