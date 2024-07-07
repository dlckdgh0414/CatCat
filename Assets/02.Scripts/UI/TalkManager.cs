using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    //[SerializeField] private TextDataListSO textDataListSO;
     public Dictionary<int, string[]> talkData;

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
        talkData.Add(9, new string[] { "배도 채웠으니 이제 산책로로 내려가볼까?" });
        talkData.Add(10, new string[] { "앞에 횡단보도가 있다.", "빨간불일때 지나가면 위험하겠지?" });
        talkData.Add(11, new string[] { "자판기다.", "가격을 보니 겜마고 보다 저렴한거같다.", "고양이만 아니였음 뽑아 먹었다." });
        talkData.Add(12, new string[] { "일반 쓰레기통이다.", "쓰레기통을 볼때마다 분리수거생각이난다." });
        talkData.Add(13, new string[] { "재활용 쓰레기통이다", "재활용 쓰레기통에 일반쓰레기도 좀 들어있는거같다.", "재활용좀하지.." });
        talkData.Add(14, new string[] { "다시 산책로로 돌아갈건가요?", "돌아가도 다시 일로 와야합니다..." });
        talkData.Add(15, new string[] { "버스정류장이다 의자에 쓰레기가 놓여져있네요.", "버스는 지금 운영하지 않는거같네요.." });
        talkData.Add(16, new string[] { "소화전이다." });
        talkData.Add(17, new string[] { "전등이다.", "이건 고장나서 켜져있지 않는거같다.." });
        talkData.Add(18, new string[] { "마을입구라 적혀있는 표지판이다.", "가면 마을 입구로 갈수 있을거같다. 가볼까?" });
        talkData.Add(19, new string[] { "산책로가는길이라고 적혀있는 표지판이다.", "다시 산책로가는길로 돌아갈까?" });
        talkData.Add(20, new string[] { "박스다.", "박스를 보니 안에 들어가고싶다..", "들어가볼까?" });
        talkData.Add(21, new string[] { "바로 앞에 뒷골목이 있는거같다.", "뒷골목으로 가볼까?" });
        talkData.Add(22, new string[] { "문이 살짝 열려있는거같다.","한번 나가볼까?" });
        talkData.Add(23, new string[] { "음식물 쓰레기가 많이 놓여져있다..","냄새가 더럽게난다.","우웩.." });
        talkData.Add(24, new string[] { "대장님 이제 출발합시다!","이제 후일담은 끝났습니다..","다시 처음부터해서 다른엔딩을 볼까요?" });
        talkData.Add(25, new string[] { "자고있는거같다..","이제 곧 출발할텐데..","암튼 우리 막내다." });
        talkData.Add(26, new string[] { "대장님 오셨군요","이제 곧 출발할테니 기다리고있겠습니다."});
        talkData.Add(27, new string[] { "소녀: 어 나비다!! 나비야 일로와!!","주인에게 안기며 고양이는 행복하게 지내는거같군요.","다시 처음부터 다른엔딩을볼까요?"});
        talkData.Add(28, new string[] { "지하철 역이있네요.","매일 기숙사올때 보는 범계역이 떠오르네요.","기숙사 가기 싫어.","지하철은 운영하지않는거같네요."});
        talkData.Add(29, new string[] { "고양이가 먹는 밥 그릇같습니다.", "비워져있는거보니 이미 밥을 먹은거같습니다." });        
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
        { 
            return talkData[id][talkIndex];
        }

    }

    private void OnEnable()
    {
        DontDestroyOnLoad(gameObject);
    }
}
