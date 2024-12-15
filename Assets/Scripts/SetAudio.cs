using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SetAudio : MonoBehaviour
{
    AudioSource music;
    float originalVolume;
    
    public float maxVolume { get; private set;}

    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        originalVolume = music.volume;
    }

    // Update is called once per frame
    void Update()
    {
        maxVolume = originalVolume * SettingsManager.Volume;
    }

    public void TimerEnd() {
        DOVirtual.Float(originalVolume, originalVolume * 0.5f, 1, (float t) => originalVolume = t);
    }
}
