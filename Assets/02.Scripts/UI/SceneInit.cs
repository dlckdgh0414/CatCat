using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SceneInit : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera vcam;

    private void Awake()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
    }

    private void Start()
    {
        vcam.Follow = GameObject.FindWithTag("Player").transform;
    }
}
