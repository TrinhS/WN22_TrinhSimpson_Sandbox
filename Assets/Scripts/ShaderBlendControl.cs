using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderBlendControl : MonoBehaviour
{
    public Material BlendMaterial;
    public string PropertyName;

    public float GreenValue = 1;
    public float YellowValue = 0.5f;
    public float RedValue = 0;

    private float BlendSpeed = 0.005f;

    private float MixValue = 0;



    // Update is called once per frame
    void Update()
    {
        BlendMaterial.SetFloat(PropertyName, MixValue);

        MixValue += BlendSpeed;
        if (MixValue > RedValue || MixValue < GreenValue)
        {
            BlendSpeed *= -1;
        }
    }
}
