using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] Image buttonImage;
    [Header("Dark Images")]
    [SerializeField] Sprite uncompressedButton;
    [SerializeField] Sprite compressedButton;

    [Header("Light Images")]
    [SerializeField] Sprite uncompressedButtonLight;
    [SerializeField] Sprite compressedButtonLight;

    bool isInLightMode;

    public void OnPointerDown(PointerEventData pointerEventData) {
        buttonImage.sprite = isInLightMode ? compressedButtonLight : compressedButton;
    }

    public void OnPointerUp(PointerEventData pointerEventData) {
        buttonImage.sprite = isInLightMode ? uncompressedButtonLight : uncompressedButton;
    }

    public void Switch(bool isLight)
    {
        isInLightMode = isLight;
        buttonImage.sprite = isInLightMode ? uncompressedButtonLight : uncompressedButton;
    }
}
