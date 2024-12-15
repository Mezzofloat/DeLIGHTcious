using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] Transform sprite1, sprite2, sprite3, sprite4;
    
    Vector2 bounds;
    
    Vector2 roundedPos;

    void Start() => RecalculateBounds();
    void RecalculateBounds() => bounds = new Vector2(0.5f * cam.orthographicSize * cam.aspect, cam.orthographicSize);

    void Update()
    {
        roundedPos = new Vector2(
            Mathf.Round(cam.transform.position.x * 0.0389f) * 12.85f * 2,
            Mathf.Round(cam.transform.position.y * 0.0389f) * 12.85f * 2);

        sprite1.position = new Vector3(roundedPos.x + 12.85f,roundedPos.y + 12.85f,2);
        sprite2.position = new Vector3(roundedPos.x + 12.85f,roundedPos.y - 12.85f,2);
        sprite3.position = new Vector3(roundedPos.x - 12.85f,roundedPos.y - 12.85f,2);
        sprite4.position = new Vector3(roundedPos.x - 12.85f,roundedPos.y + 12.85f,2);
    }
}
