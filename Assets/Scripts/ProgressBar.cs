using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] Image progressBar;
    [SerializeField] SwitchToLight stl;

    public void Switch(bool isLight)
    {
        if (isLight) {
            ScoreManager.AddToScore(30);
            StartCoroutine(nameof(SwitchCoroutine)); 
        }
    }

    IEnumerator SwitchCoroutine() {
        while (progressBar.fillAmount > 0) {
            progressBar.fillAmount -= Time.deltaTime * 0.1f;
            yield return new WaitForEndOfFrame();
        }
        stl.OnLight(true);
    }

    public void AddToProgress(float t) {
        DOVirtual.Float(progressBar.fillAmount, progressBar.fillAmount + t, 0.2f, (float t) => progressBar.fillAmount = t);
    }
}
