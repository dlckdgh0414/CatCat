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
        talkData.Add(100, new string[] {"낡은 표지판이다.", "표지판에 크게 글자가 써져있는거같다.", "확인해볼까?" });
        talkData.Add(200, new string[] {"늙은 할아버지가 의자옆에 서 있다.", "한번 다가가 볼까?"});
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
