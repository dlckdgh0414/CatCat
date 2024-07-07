using System.Collections;
using UnityEngine;
using TMPro;

public class TextEffect : MonoBehaviour
{
    private string _targetMsg;
    public int CharPerSceonds;
    [SerializeField] GameObject EndCursor;
    [SerializeField] TMP_Text _text;
    int index;
    float interval;
    public bool isEffting = true;
    public bool end = false;

    public static TextEffect Intance;

    private void Update()
    {
        if(Ending2.Intance.isEnd)
        {
            isEffting = false;
        }
    }

    private void Awake()
    {
        //_text = GetComponent<TMP_Text>();
        if(Intance == null)
        {
            Intance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetMsg(string msg)
    {
        _targetMsg = msg;
        EffectStart();
    }

    private void EffectStart()
    {
        _text.text = "";
        index = 0;
        EndCursor.SetActive(false);
        interval = 0.05f;
        TextManager.Intance.TalkPanel.SetActive(true);
        StartCoroutine(Effecting());
    } 
    private IEnumerator Effecting()
    {
        while (true)
        {
            if (_text.text == _targetMsg)
            {
                EffectEnd();
                yield break;
            }
            isEffting = false;
            _text.text += _targetMsg[index];
            index++;
            yield return new WaitForSeconds(interval);
        }
    } 
    private void EffectEnd()
    {
        EndCursor.SetActive(true);
        isEffting = true;
    }
}
