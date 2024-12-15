using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using DG.Tweening;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text scoreTextEndScreen;

    static ScoreManager Instance;
    public static int score { get; private set; }
    static int prevScore;

    void Awake() {
        Instance = this;
        score = 0;
    }

    public static void AddToScore(int i) {
        DOVirtual.Int(score, score + i, 0.3F, (int t) => { 
            Instance.scoreText.text = t.ToString();
            score = t; 
        }).SetEase(Ease.Linear);
    }

    public void TimerEnd() {
        scoreTextEndScreen.text = "Score: \n" + score.ToString();
    }
}
