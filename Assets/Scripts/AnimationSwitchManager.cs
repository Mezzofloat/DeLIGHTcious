using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwitchManager : MonoBehaviour
{
    [SerializeField] Animator player = new();

    public void Switch(bool isLight) {
        player.speed = isLight ? 1.5f : 1;
    }
}
