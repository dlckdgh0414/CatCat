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

    internal static void LoadScene(object name)
    {
        throw new NotImplementedException();
    }

    internal static object GetActiveScene()
    {
        throw new NotImplementedException();
    }

    internal static void LoadScene(int v)
    {
        throw new NotImplementedException();
    }
}
