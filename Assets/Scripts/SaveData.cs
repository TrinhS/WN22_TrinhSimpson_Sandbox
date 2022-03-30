using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class SaveData : MonoBehaviour
{
    PlayerData ui;
    AnimationToggle UI;

    private void Awake()
    {
        ui = GetComponent<PlayerData>();
        UI = GetComponent<AnimationToggle>();
    }

    public void SaveGame()
    {
        ui.intToSave = Mathf.RoundToInt(ui.intSlider.value);
        ui.stringToSave = ui.introText.text;
        //UI.stringToSave = UI.greenMessage.text;
        //UI.stringToSave = UI.blueMessage.text;
        PlayerPrefs.SetInt("SavedInteger", ui.intToSave);
        PlayerPrefs.SetString("SavedString", ui.stringToSave);
        PlayerPrefs.SetString("SavedString", UI.stringToSaveG);
        PlayerPrefs.Save();
        ui.introText.text = UI.stringToSaveG + "and on a scale of 1-10 on being adventurous, you selected " + ui.intToSave.ToString();
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

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        ui.intToSave = 0;
        ui.intText.text = "How adventurous are you?  Scale between 1-10" ;
        UI.stringToSaveG = "";

        ui.intSlider.value = ui.intToSave;

    }
}
