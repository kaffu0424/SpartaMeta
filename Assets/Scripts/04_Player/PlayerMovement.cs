using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    [Range(0f, 5)]
    private float moveSpeed;

    private Rigidbody2D rigidBody;
    private Animator    animator;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        // UI로 인한 움직임 방지
        if (UIManager.Instance.IsMovementBlocked)
        {
            rigidBody.velocity = Vector3.zero;
            return;
        }

        float hori = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");

        rigidBody.velocity = new Vector2(hori, verti) * moveSpeed;

        animator.SetFloat("moveX", hori);
        animator.SetFloat("moveY", verti);
    }
}
