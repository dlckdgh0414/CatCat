using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QusetData : MonoBehaviour
{
    public string qusetName;
    public int[] npcId;

    public QusetData(string name, int[] npc)
    {
        qusetName = name;
        npcId = npc;
    }
}
