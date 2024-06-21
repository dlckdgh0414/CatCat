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
    public static ObjData instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
