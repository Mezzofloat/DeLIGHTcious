using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[System.Serializable]
public class Food : MonoBehaviour
{
    public Sprite darkMode;

    public int score;
    [Range(0,1)] public float progress;
    public float waitTime;

    void Awake() => PlayerInteract.foodList.Add(this);
    void OnDestroy() => PlayerInteract.foodList.Remove(this);
}
