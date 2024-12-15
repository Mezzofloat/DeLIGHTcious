using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class SwitchToLight : MonoBehaviour
{
    [SerializeField] UnityEvent<bool> switchEvent;
    [SerializeField] Image progressBar;
    [SerializeField] GameObject invertColors;

    bool isOnLight;

    void OnLight() {
        if (progressBar.fillAmount >= 0.6f) {
            OnLight(false);
        }
    }

    public void OnLight(bool overrode) {
        if (!isOnLight || overrode) {
            isOnLight = !isOnLight;
            var c = invertColors.GetComponent<Volume>();
            c.weight = 1 - c.weight;
            switchEvent?.Invoke(isOnLight);
        }
    }
}
