using System.Collections;

using UnityEngine;

using UnityEngine.Playables;


public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public PlayableDirector timeLine;
    [SerializeField] GameObject Playerpos;
    private void Awake()
    {
        gameObject.SetActive(false);
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        Playerpos = GameObject.Find("Player");
    }

    public void OnClik(int sceneNum)
    {
        Time.timeScale = 1;
        StartCoroutine(delay(3,sceneNum));
        timeLine.Play();
    }
    public void YesClik(int sceneNum)
    {
        Time.timeScale = 1;
        Playerpos.transform.position = Vector2.zero;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNum);
    }
    public void NoClik()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    IEnumerator delay(float delayTime, int sceneNum)
    {
        yield return new WaitForSeconds(delayTime);
        Playerpos.transform.position = Vector2.zero;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNum);
    }
}
