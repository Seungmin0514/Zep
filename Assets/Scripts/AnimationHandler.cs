using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{

    protected Animator animator;
    // Start is called before the first frame update
    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    
    void OnMove()
    {
        animator.SetBool("IsMove",true);
    }
}
