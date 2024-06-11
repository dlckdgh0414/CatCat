using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particle;
    [SerializeField] private ParticleSystem _particle2;
    private float _duration;
    private WaitForSeconds _particleDuration;
   // [SerializeField] private GameObject[] _effectPrefab;
   // [SerializeField] private Transform _effectPos;

    private void Awake()
    {
       // _particle = GetComponent<ParticleSystem>();
       // _particle2 = GetComponent<ParticleSystem>();
       // _duration = _particle.main.duration;
       // _particleDuration = new WaitForSeconds(_duration);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Fish")|| collision.gameObject.CompareTag("GoldFish"))
        {
            // GameObject effectObj = Instantiate(_effectPrefab[0], _effectPos);
            _particle.Play();
          // _particle.Stop();
          // _particle.Simulate(0);
        }

        if(collision.gameObject.CompareTag("Trash")|| collision.gameObject.CompareTag("BigTrash"))
        {
            //GameObject effectObj = Instantiate(_effectPrefab[1], _effectPos);
            _particle2.Play();
          //  _particle2.Stop();
          // _particle2.Simulate(0);
        }
    }
}
