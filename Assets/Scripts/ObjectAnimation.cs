using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
using TMPro;

public class ObjectAnimation : MonoBehaviour
{
    [SerializeField]
    Animator redCube;
    [SerializeField]
    Animator yellowCube;


    public void RedAnimator()
    {
        if (!redCube.GetBool("RedMessage"))
        {
            redCube.SetBool("RedMessage", true);
        }
        else
        {
            redCube.SetBool("RedMessage", false);
        }
    }

    public void YellowAnimator()
    {
        if (!yellowCube.GetBool("YellowMessage"))
        {
            yellowCube.SetBool("YellowMessage", true);
        }
        else
        {
            yellowCube.SetBool("YellowMessage", false);
        }
    }
}
