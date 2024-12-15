using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerSpriteSwitch : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] RuntimeAnimatorController darkMode;
    [SerializeField] RuntimeAnimatorController lightMode;

    public void Switch(bool isLight) => anim.runtimeAnimatorController = isLight ? lightMode : darkMode;
}
