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
    public string stringToSaveG;

    public void GreenAnimator()
    {
        if (!animatorEx.GetBool("WarmingUp"))
        {
            animatorEx.SetBool("WarmingUp", true);
            greenMessage.text = "You chose Green! Get ready for your adventure! Press the Yellow Button!";
            stringToSaveG = greenMessage.text;
            blueMessage.text = "";

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
            blueMessage.text = "You chose Blue! Night, Night! Press the Red Button";
            stringToSaveG = blueMessage.text;
            greenMessage.text = "";
        }
        else
        {
            animatorRe.SetBool("KnockedOut", false);
        }
    }

    public void ClearTxtG()
    {
        greenMessage.text = "";

    }

    public void ClearTxtB()
    {
        blueMessage.text = "";
    }

    public void DisableBlue()
    {
        animatorRe.SetBool("KnockedOut", false);
    }

    public void DisableGreen()
    {
        animatorEx.SetBool("WarmingUp", false);
    }
}
