using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class ScrollTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject scrollClosed;
    bool scrollActive = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !scrollActive)
        {
            scrollClosed.SetActive(true);
            scrollActive = true;
        }
    }

}
