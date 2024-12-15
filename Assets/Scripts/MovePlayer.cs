using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] float speed;

    Vector2 val;

    void OnMove(InputValue value) { 
        val = value.Get<Vector2>();

        if (val.x != 0 || val.y != 0) {
            animator.SetFloat("X", val.x);
            animator.SetFloat("Y", val.y);

            animator.SetBool("IsWalking", true);
        } else {
            animator.SetBool("IsWalking", false);
        }
    }

    void Update() {
        transform.Translate(Time.deltaTime * speed * new Vector3(val.x, val.y));
    }

    public void Switch(bool isLight) => speed = isLight ? 10 : 5;

    public void TimerEnd() => gameObject.GetComponent<PlayerInput>().DeactivateInput();
}
