using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    [SerializeField] private TextDataListSO textDataListSO;


    public string GetTalk(int id, int talkIndex)
    {
        Debug.Log(talkIndex);
        Debug.Log(textDataListSO.list[id].text.Count);
        if (talkIndex <= textDataListSO.list.Count)
        {
            return textDataListSO.list[id].text[talkIndex];
        }
        return "NULL";
    }
}
