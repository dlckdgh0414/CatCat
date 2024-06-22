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
        talkData.Add(1, new string[] { "엄청 큰 돌이다.", "이쪽으론 지나갈 순 없을 거 같다.", "아쉽다 ㅋ" });
        talkData.Add(2, new string[] { "고양이가 맛있게 먹고 남긴 뼈 조각이다.", "고양이는 배가 부른거같다.", "이제 어디로 갈까?" });
        talkData.Add(3, new string[] { "고양이는 지금 배가 매우 고픈거같다.", "연못가에 물고기가 많은거같다.", "우리가 고양이를 위해 물고기를 잡아줄까요?" });
        talkData.Add(4, new string[] { "주인이 없는 낚시의자와 낚시대가 있다.", "이 물가에 물고기가 굉장히 많은거같다.", });
        talkData.Add(5, new string[] { "고양이가 배가 고프고 목말라합니다.", "마침 갈림길이 있네요", "표지판에는 연못가와 산책로라고 적혀있습니다.", "어디로 가는게 좋을까요?" });
        talkData.Add(6, new string[] { "고양이는 아직 배를 채우지 못했습니다. 그래도 돌아가실 건가요?" });
        talkData.Add(7, new string[] { "다시 돌아가실건가요?" });
        talkData.Add(8, new string[] { "표지판에 도시로 내려가는길이라 써져있다", "도시로 내려가볼까?", "*주의 아직까지 고양이에게 밥을 안줬다면 위험할수도있습니다.", "밥을 줬다면 도시로 내려가볼까요?" });
        talkData.Add(9, new string[] { "배도 채웠으니 이제 산책로로 내려가볼까?"});
        talkData.Add(10, new string[] { "앞에 횡단보도가 있다.", "빨간불일때 지나가면 위험하겠지?" });
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
