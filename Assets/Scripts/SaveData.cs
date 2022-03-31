using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEditor;

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
        
        Debug.Log("Game data saved!");
    }

    public void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedInteger"))
        {
            ui.intToSave = PlayerPrefs.GetInt("SavedInteger");
            ui.stringToSave = PlayerPrefs.GetString("SavedString");
            ui.introText.text = UI.stringToSaveG + "and on a scale of 1-10 on being adventurous, you selected " + ui.intToSave.ToString();

        }
    }

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        ui.intToSave = 0;
        ui.intSlider.value = ui.intToSave;
        ui.intText.text = "How adventurous are you?  Scale between 1-10" ;
        UI.stringToSaveG = "";
        UI.greenMessage.text = "Green Button: Enter into a world of new possiblities and challenges. See where the world of VXR will lead you.";
        UI.blueMessage.text = "Blue Button: School ends and you can sleep for as long as you like. You can finally RELAX!";
    }

    public void OnApplicationQuit()
    {
        SaveGame();
        EditorApplication.isPlaying = false;
    }
}
