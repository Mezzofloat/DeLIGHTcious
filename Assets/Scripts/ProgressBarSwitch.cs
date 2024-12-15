using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgressBarSwitch : MonoBehaviour
{
    [SerializeField] Image progress;
    [SerializeField] Image outline;

    [Header("Images")]
    [SerializeField] Sprite darkMode;
    [SerializeField] Sprite lightMode;

    public void Switch(bool isLight)
    {
        progress.color = isLight ? Color.black : Color.white;
        outline.sprite = isLight ? lightMode : darkMode;
    }
}
