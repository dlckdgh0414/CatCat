using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KoreanTyper;
using TMPro;
using System;

public class UITextTyper : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI[] _tmp;

    private void Start()
    {
        StartCoroutine(TypingText());
    }
    private IEnumerator TypingText()
    {
            while (true)
            {
                string[] test = new string[4]{"테스트용",
                    "집가고싶다.",
                    "청소하기싫다",
                    "아앙" };
                foreach (TextMeshProUGUI t in _tmp)
                    t.text = "";

                for(int t = 0; t < test.Length && t < test.Length; t++)
                { 
                    int strTypingLength = test[t].GetTypingLength();

                    for (int i = 0; i <= strTypingLength; i++)
                    {
                        _tmp[t].text = test[t].Typing(i);
                        yield return new WaitForSeconds(0.03f);
                    }
                    yield return new WaitForSeconds(1f);
                }
                yield return new WaitForSeconds(1f);
            
        }
    }
}
