using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgePlayer : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private Animator animator;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float hori = Input.GetAxisRaw("Horizontal");

        rigidbody.velocity = new Vector2(hori, 0) * 4;

        animator.SetFloat("moveX", hori);
    }
}
