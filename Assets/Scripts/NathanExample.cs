using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NathanExample : MonoBehaviour
{
    [SerializeField] Animator animator;
    public int p, ss;
    [SerializeField] string para;

    private void Awake()
    {
        ss = 0;
        p = 1;
    }

    public void AniSwap()
    {
        if (p == 1)
        {
            animator.SetBool(para, false);
            p = 0;
        }
        else if (p == 0)
        {
            animator.SetBool(para, true);
            p = 1;
        }
    }



  
}
