using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
using TMPro;

public class AnimationToggle : MonoBehaviour
{
    public Animator animatorEx;
    public Animator animatorRe;
    public TextMeshProUGUI blueMessage;
    public TextMeshProUGUI greenMessage;
    public string stringToSave;

    public void GreenAnimator()
    {
        if (!animatorEx.GetBool("WarmingUp"))
        {
            animatorEx.SetBool("WarmingUp", true);
            greenMessage.text = "You chose Green! Get ready for your adventure!";
            stringToSave = greenMessage.text;

        }
        else
        {
            animatorEx.SetBool("WarmingUp", false);
        }
    }

    public void BlueAnimator()
    {
        if (!animatorRe.GetBool("KnockedOut"))
        {
            animatorRe.SetBool("KnockedOut", true);
            blueMessage.text = "You chose Blue! Night, Night!";
            stringToSave = blueMessage.text;
        }
        else
        {
            animatorRe.SetBool("KnockedOut", false);
        }
    }
}
