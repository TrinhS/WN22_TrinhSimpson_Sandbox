using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartAnimation : MonoBehaviour
{
    public Animator cube;
    public TextMeshProUGUI onOffLabel;
    public TextMeshProUGUI startStop;
    void Start()
    {
        if (!cube.GetBool("Start"))
        {
            onOffLabel.text = "Off";
            startStop.text = "Stop";
        }
        else
            onOffLabel.text = "On";
        startStop.text = "Start";
    }

    public void playAnimation()
    {
        cube.SetBool("Start", true);
        onOffLabel.text = "On";
    }

}
