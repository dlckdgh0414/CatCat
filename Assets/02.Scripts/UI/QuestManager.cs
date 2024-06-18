using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public int questId;

    Dictionary<int, QusetData> questList;

    private void Awake()
    {
        questList = new Dictionary<int, QusetData>();
        GenerateData();
    }

    private void GenerateData()
    {
        questList.Add(5, new QusetData("물건 터치",new int[] {1}));
    }
}
