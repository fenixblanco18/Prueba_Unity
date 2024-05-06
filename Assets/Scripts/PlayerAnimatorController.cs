using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    Animator animator;
    CharacterController characterController;
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        characterController = GetComponentInChildren<CharacterController>();
    }

    void Update()
    {
        animator.SetFloat("Velocity", characterController.velocity.magnitude);
    }
}
