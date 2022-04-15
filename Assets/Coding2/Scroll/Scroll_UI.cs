
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
    GameObject scrollMenu;
    [SerializeField]
    GameObject closeButton;
    [SerializeField]
    GameObject openButton;
    [SerializeField]
    GameObject hideButton;
    [SerializeField]
    GameObject scrollButton;

    //new object is active, old object is disabled
    public void Close()
    {
        closed.SetActive(true);
        open.SetActive(false);
        scrollMenu.SetActive(false);
        closeButton.SetActive(false);
        scrollButton.SetActive(false);
        openButton.SetActive(true);
        hideButton.SetActive(true);
    }

    public void Open()
    {
        closed.SetActive(false);
        open.SetActive(true);
        scrollMenu.SetActive(true);
        closeButton.SetActive(true);
        openButton.SetActive(false);
        scrollButton.SetActive(false);
        hideButton.SetActive(false);
    }

    public void Hide()
    {
        closed.SetActive(false);
        open.SetActive(false);
        scrollMenu.SetActive(false);
        closeButton.SetActive(false);
        openButton.SetActive(false);
        hideButton.SetActive(false);
        scrollButton.SetActive(true);
    }

    public void Unhide()
    {
        Close();
    }
}

