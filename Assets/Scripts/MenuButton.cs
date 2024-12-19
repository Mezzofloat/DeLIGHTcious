using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] Image buttonImage;
    [Header("Images")]
    [SerializeField] Sprite uncompressedButton;
    [SerializeField] Sprite compressedButton;

    public void OnPointerDown(PointerEventData pointerEventData) {
        buttonImage.sprite = compressedButton;
    }

    public void OnPointerUp(PointerEventData pointerEventData) {
        buttonImage.sprite = uncompressedButton;
    }
}
