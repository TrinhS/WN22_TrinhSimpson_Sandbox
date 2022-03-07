using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    public Animator animator;

    public void TransitionAnimation()
    {
        if (!animator.GetBool("Toggle"))
        {
            animator.SetBool("Toggle", true);
        }
        else animator.SetBool("Toggle", false);
    }

}
