using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LimitSwitch : MonoBehaviour
{
    [SerializeField] Image limit;

    public void Switch(bool isLight) {
        limit.color = isLight ? Color.black : Color.white;
    }
}
