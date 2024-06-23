using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using KoreanTyper;

public class Endingt : MonoBehaviour
{
    public TextMeshProUGUI[] TestTexts;
    [SerializeField] GameObject Buttons;

    private void Start()
    {
        StartCoroutine(TypingText());
        Buttons.SetActive(false);
    }

    public IEnumerator TypingText()
    {
        while (true)
        {
            //=======================================================================================================
            // Initializing | 초기화
            //=======================================================================================================
            string[] strings = new string[4] { "Ending2", "뒷골목으로간 고양이는 뒷골목에서 대장이된거같군요.", "대장이된 고양이는 고양이들을 대리고 다니는거같아요.", "고양이가 어떻게 지내는지 한번 보러갈까요?" };
            foreach (TextMeshProUGUI t in TestTexts)
                t.text = "";
            //=======================================================================================================


            //=======================================================================================================
            //  Typing effect | 타이핑 효과
            //=======================================================================================================
            for (int t = 0; t < TestTexts.Length && t < strings.Length; t++)
            {
                int strTypingLength = strings[t].GetTypingLength();

                for (int i = 0; i <= strTypingLength; i++)
                {
                    TestTexts[t].text = strings[t].Typing(i);
                    yield return new WaitForSeconds(0.03f);
                }
                // Wait 1 second per 1 sentence | 한 문장마다 1초씩 대기
                yield return new WaitForSeconds(1f);
            }
            break;
        }
        Buttons.SetActive(true);
    }
}
