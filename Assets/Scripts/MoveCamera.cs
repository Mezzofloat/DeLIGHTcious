using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] Transform player;

    Tweener tweener;

    void Update() {
        tweener.Kill();
        if ((transform.position - player.position).sqrMagnitude > 0.0001f) {
            tweener = transform.DOMove(new Vector3(player.position.x, player.position.y, -10), 0.5f).SetEase(Ease.OutSine);
        }
    }

    public void Switch(bool isLight)
    {
        var cam = GetComponent<Camera>();
        DOVirtual.Float(cam.orthographicSize, isLight ? 7 : 5, 0.3f, (float t) => {cam.orthographicSize = t;});
    }
}
