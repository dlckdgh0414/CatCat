using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingButton : MonoBehaviour
{
    [SerializeField] GameObject settingUi;
    public void SettingButtonClik()
    {
        settingUi.gameObject.SetActive(true);
    }
}
