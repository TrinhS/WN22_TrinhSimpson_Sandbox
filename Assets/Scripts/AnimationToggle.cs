using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AnimationToggle : MonoBehaviour
{
    public Animator animatorEx;
    public Animator animatorRe;
    public void ExpectationsAnimator()
    {
        if (!animatorEx.GetBool("WarmingUp"))
        {
            animatorEx.SetBool("WarmingUp", true);
        }
        else
        {
            animatorEx.SetBool("WarmingUp", false);
        }
    }

    public void RealityAnimator()
    {
        if (!animatorRe.GetBool("KnockedOut"))
        {
            animatorRe.SetBool("KnockedOut", true);
        }
        else
        {
            animatorRe.SetBool("KnockedOut", false);
        }
    }
}
