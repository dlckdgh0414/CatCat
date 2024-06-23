using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjData : MonoBehaviour
{
    public int id;
    public bool isNPC;
    public bool isChoose;
    public bool isPos;
    public bool isYesNo;
    public bool isClity;
    public bool isReChoose;
    public bool isHille;
    public bool isTown;
    public bool isCityBack;
    public bool isEndingjunction;
    public bool isEnding;
    public bool isBack;
    public bool isNextHouse;
    public static ObjData instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
