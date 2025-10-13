using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripAnimation : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        if (animator != null)
        {

        }
        else
        {
            Debug.LogError("Animator component not found on this GameObject.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("start", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("start", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("start2", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("start2", false);
        }
    }
}
