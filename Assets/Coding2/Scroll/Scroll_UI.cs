using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll_UI : MonoBehaviour
{
    [SerializeField]
    GameObject closed;
    [SerializeField]
    GameObject open;
    [SerializeField]
    GameObject scrollText;
    [SerializeField]
    GameObject closeButton;
    [SerializeField]
    GameObject openButton;
    //new object is active, old object is disabled
    public void Close()
    {
        closed.SetActive(true);
        open.SetActive(false);
        scrollText.SetActive(false);
        closeButton.SetActive(false);
        openButton.SetActive(true);
    }

    public void Open()
    {
        closed.SetActive(false);
        open.SetActive(true);
        scrollText.SetActive(true);
        closeButton.SetActive(true);
        openButton.SetActive(false);
    }
}

