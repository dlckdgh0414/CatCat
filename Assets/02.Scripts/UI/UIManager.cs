using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public PlayableDirector timeLine;

    private void Awake()
    {
        gameObject.SetActive(false);
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    public void OnClik(int sceneNum)
    {
        Time.timeScale = 1;
        StartCoroutine(delay(2,sceneNum));
        timeLine.Play();
    }
    public void NoClik()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    IEnumerator delay(float delayTime, int sceneNum)
    {
        yield return new WaitForSeconds(delayTime);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNum);
    }
}
