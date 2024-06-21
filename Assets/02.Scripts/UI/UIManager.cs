using System.Collections;

using UnityEngine;

using UnityEngine.Playables;


public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public PlayableDirector timeLine;
    [SerializeField] GameObject Playerpos;
    [SerializeField] GameObject Image;
    public bool _pool;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        Playerpos = GameObject.Find("Player");
    }

    public void UpOnClik(int sceneNum)
    {
        Time.timeScale = 1;
        StartCoroutine(delay(3,sceneNum));
        timeLine.Play();
        _pool = true;
    }
    public void DownOnClik(int sceneNum)
    {
        Time.timeScale = 1;
        StartCoroutine(delay(3,sceneNum));
        timeLine.Play();
    }
    
    IEnumerator delay(float delayTime, int sceneNum)
    {
        yield return new WaitForSeconds(delayTime);
        Playerpos.transform.position = Vector2.zero;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNum);
        TextManager.Intance.isFreeze = true;
        gameObject.SetActive(false);

    }
}
