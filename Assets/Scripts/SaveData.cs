using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class SaveData : MonoBehaviour
{
    PlayerData ui;

    private void Start()
    {
        ui = GetComponent<PlayerData>();
    }

    public void SaveGame()
    {
        ui.intToSave = Mathf.RoundToInt(ui.intSlider.value);
        ui.stringToSave = ui.introText.text;
        PlayerPrefs.SetInt("SavedInteger", ui.intToSave);
        PlayerPrefs.SetString("SavedString", ui.stringToSave);
        PlayerPrefs.Save();
        ui.introText.text = "On a scale of 1-10 on being adventurous, you selected " + ui.intToSave.ToString();
        Debug.Log("Game data saved!");
    }

    public void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedInteger"))
        {
            ui.intToSave = PlayerPrefs.GetInt("SavedInteger");
            ui.stringToSave = PlayerPrefs.GetString("SavedString");
            
        }
    }
}
