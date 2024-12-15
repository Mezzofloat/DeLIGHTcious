using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] Image progressBar;
    [SerializeField] ProgressBar pb;

    public static List<Food> foodList = new();

    void OnPickup() {
        var toBeDestroyedList = new List<Food>();
        foreach (var f in foodList) {
            if ((f.transform.position - transform.position).sqrMagnitude < 3f) {
                ScoreManager.AddToScore(f.score);
                pb.AddToProgress(f.progress);
                toBeDestroyedList.Add(f);
            }
        }

        foreach (var f in toBeDestroyedList)  {
            Destroy(f.gameObject);
        }
    }
}
