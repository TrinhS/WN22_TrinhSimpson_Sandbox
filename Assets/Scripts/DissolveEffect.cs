using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveEffect : MonoBehaviour
{
    public Material dissolveMat;
    public float health;
    public float maxhealth;

    public void Start()
    {
        dissolveMat.SetFloat("", health / maxhealth);
    }
}
