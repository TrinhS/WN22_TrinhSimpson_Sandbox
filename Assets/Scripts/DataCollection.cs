using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataCollection : MonoBehaviour
{
    public int intToSave;
    public float floatToSave;
    public string stringToSave;

    public Slider intSlider, floatSlider;

    public TMP_InputField userName;

    public TextMeshProUGUI floatText;
    public TextMeshProUGUI intText;
    public TextMeshProUGUI dataText;

    public void ChangeSlider()
    {
        intToSave = Mathf.RoundToInt(intSlider.value);
        intText.text = intToSave.ToString();
        floatToSave = floatSlider.value;
        floatText.text = floatToSave.ToString();
    }

}
