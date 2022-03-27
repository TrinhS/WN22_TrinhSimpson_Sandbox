using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerData : MonoBehaviour
{
    public int intToSave;
    public string stringToSave;

    public Slider intSlider;

    public TextMeshProUGUI intText;
    public TextMeshProUGUI introText;

    public void ChangeSlider()
    {
        intToSave = Mathf.RoundToInt(intSlider.value);
        intText.text = intToSave.ToString();
    }
}
