using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI talkText;
    [SerializeField] private GameObject scanObject;

    public void Action(GameObject scanObj)
    {
        scanObject = scanObj;
        talkText.text = "이것의 이름은" +scanObject.name + "이라고 한다.";
    }
}
