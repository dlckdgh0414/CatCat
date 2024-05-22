using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    public void next()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
