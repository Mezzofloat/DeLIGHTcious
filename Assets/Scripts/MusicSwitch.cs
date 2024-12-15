using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MusicSwitch : MonoBehaviour
{
    [SerializeField] AudioSource darkPlayer, lightPlayer;

    public void Switch(bool isLight) {
        var end = isLight ? darkPlayer : lightPlayer;
        var begin = isLight ? lightPlayer : darkPlayer;

        begin.volume = 0;
        begin.Play();

        DOVirtual.Float(darkPlayer.volume, 0, 1.5f, (float t) => end.volume = t).SetEase(Ease.InSine);
        DOVirtual.Float(0, GetComponent<SetAudio>().maxVolume, 1.5f, (float t) => begin.volume = t).SetEase(Ease.OutSine);
    }
}
