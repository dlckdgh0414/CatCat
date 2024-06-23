using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic4 : MonoBehaviour
{

    private AudioSource _audioSource;

    public static BackGroundMusic4 Intance;
    private void Awake()
    {
        if (Intance == null)
            Intance = this;
        else
            Destroy(gameObject);
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}
