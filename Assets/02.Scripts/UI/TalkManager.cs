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
        talkData.Add(0, new string[] { "낡은 벤치다" });
        talkData.Add(1, new string[] { "엄청 큰 돌이다.","이쪽으론 지나갈 순 없을 거 같다.","아쉽다 ㅋ" });
        talkData.Add(2, new string[] { "고양이가 맛있게 먹고 남긴 뼈 조각이다.", "고양이는 배가 부른거같다.", "이제 어디로 갈까?" });
        talkData.Add(3, new string[] { "고양이는 지금 배가 매우 고픈거같다.","연못가에 물고기가 많은거같다.","우리가 고양이를 위해 물고기를 잡아줄까요?" });
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
