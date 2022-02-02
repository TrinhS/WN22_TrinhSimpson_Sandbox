using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class ScreenActivate : MonoBehaviour
{
    [SerializeField]
    private UnityEvent playerTrigger;
    [SerializeField]
    private UnityEvent playerExit;
    [SerializeField]
    public Canvas monitor;
    [SerializeField]
    private AudioSource monitorAudio;
    public GameObject player;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerTrigger.Invoke();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerExit.Invoke();
        }
    }

}
