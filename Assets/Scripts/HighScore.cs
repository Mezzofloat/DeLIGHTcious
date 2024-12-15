using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class HighScore : MonoBehaviour
{
    [SerializeField] GameObject endScreen;
    [SerializeField] TMP_Text scoreText, newBest;

    static int highScore;

    public void TimerEnd()
    {
        if (highScore < ScoreManager.score) newBest.color = Color.white;
        
        highScore = Mathf.Max(ScoreManager.score, highScore);
        endScreen.transform.DOScale(1, 1.5f).SetEase(Ease.InBounce);
        scoreText.text = "High Score: \n" + highScore.ToString();
    }
}
