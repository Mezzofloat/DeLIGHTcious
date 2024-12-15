using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpriteSwitch : MonoBehaviour
{
    [SerializeField] Sprite darkMode, lightMode;
    [SerializeField] SpriteRenderer sr;

    public void Switch(bool isLight) {
        sr.sprite = isLight ? lightMode : darkMode;
    }
}
