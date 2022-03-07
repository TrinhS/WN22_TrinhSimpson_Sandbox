using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Animator animator;

    public void FreezeAnimation()
    {
        if (!animator.GetBool("Freeze"))
        {
            animator.SetBool("Freeze", true);
        }
        else animator.SetBool("Freeze", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            FreezeAnimation();
        }

    }
}