using TMPro;
using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class TimerManager : MonoBehaviour
{
    [SerializeField] float startingTime = 10f;
    [SerializeField] TMP_Text timerText;

    public static float t;
    public UnityEvent onTimerEnd;

    bool b;
    bool timerTicks = true;

    void Start() => t = startingTime;

    void Update()
    {
        if (timerTicks) {
            t -= Time.deltaTime;
        }
        UpdateTimer();

        if ((int)t == 0 && !b) {
            b = !b;
            onTimerEnd?.Invoke();
            t += Time.deltaTime;
        }
    }

    public void Switch(bool isLight) { 
        timerTicks = !timerTicks;
        if (isLight) {
            DOVirtual.Float(t, t + 40, 0.3f, (float s) => { 
                t = s;
                UpdateTimer();
            }).SetEase(Ease.OutSine);
        }
    }

    void UpdateTimer() {
        timerText.text = ((int)t).ToString() + "s";
    }
}
