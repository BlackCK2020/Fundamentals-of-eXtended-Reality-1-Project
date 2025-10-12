using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripAnimation : MonoBehaviour
{
    public Animator animator;
    public bool b = false;

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            b = !b;
            animator.SetBool("start", true);
            animator.SetBool("Animation", b);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {

            animator.SetBool("start", false);
        }
    }
}
