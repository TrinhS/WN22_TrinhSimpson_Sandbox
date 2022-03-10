using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorSlider : MonoBehaviour
{
    public GameObject myObject;

    public MeshRenderer meshColor;

    public Slider red, green, blue;

    Color localColor;
    Color color;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetColor()
    {
        Color color = meshColor.material.color;
        color.r = red.value;
        color.g = green.value;
        color.b = blue.value;
        meshColor.material.color = color;
        meshColor.material.SetColor("Emission", color);
    }

    public void ColorSave()
    {
        localColor = myObject.GetComponent<MeshRenderer>().material.color;
     
    }
}
