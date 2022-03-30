using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonChoice : MonoBehaviour
{
    public Animator blueReact;
    public Animator greenReact;
    public int yawning;
    public int fighting;

    public void PickButton()
    {
       //f //lueReact.GetInteger(yawning))
        {
            blueReact.SetInteger("Yawning", 1);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
