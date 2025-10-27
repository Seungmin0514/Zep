using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationHandler : MonoBehaviour
{

    protected Animator animator;
    // Start is called before the first frame update
    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame

    public void AnimationCanceled(InputAction.CallbackContext context)
    {
        animator.SetBool("IsMove", false);
    }
    public void AnimationPerformed(InputAction.CallbackContext context)
    {
        animator.SetBool("IsMove", true);

    }
}
