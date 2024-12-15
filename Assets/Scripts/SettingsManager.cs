using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public static float Volume { get; private set; } = 1;
    public static bool ChangeMusic = true;

    public void SetVolume(float v) {
        Volume = v;
    }

    public void SetChangeMusic(bool b) {
        ChangeMusic = b;
    }
}
