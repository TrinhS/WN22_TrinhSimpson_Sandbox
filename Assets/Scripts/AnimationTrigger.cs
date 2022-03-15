using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) SwitchAnimation();
    }

    public void SwitchAnimation()
    {
        if (!animator.GetBool("Toggle"))
        {
            animator.SetBool("Toggle", true);
        }
        else animator.SetBool("Toggle", false);
    }
}
