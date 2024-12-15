using TMPro;
using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

public class TimerManager : MonoBehaviour
{
    [SerializeField] float startingTime = 10f;
    [SerializeField] TMP_Text timerText;

    public static float t;
    public UnityEvent onTimerEnd;

    bool b;

    void Start() => t = startingTime;
    void Update()
    {
        t -= Time.deltaTime;
        timerText.text = ((int)t).ToString() + "s";

        if ((int)t == 0 && !b) {
            b = !b;
            onTimerEnd?.Invoke();
            t += Time.deltaTime;
        }
    }

    public void Switch(bool isLight) { 
        if (isLight) t += 40;
    }
}
