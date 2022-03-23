using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SavePrefs : MonoBehaviour
{
    DataCollection ui;



    // Start is called before the first frame update
    void Start()
    {
        ui = GetComponent<DataCollection>();
    }

    public void SaveGame()
    {
        ui.intToSave = Mathf.RoundToInt(ui.intSlider.value);
        ui.floatToSave = ui.floatSlider.value;
        ui.stringToSave = ui.userName.text;
        PlayerPrefs.SetInt("SavedInteger", ui.intToSave);
        PlayerPrefs.SetFloat("SavedFloat", ui.floatToSave);
        PlayerPrefs.SetString("SavedString", ui.stringToSave);
        PlayerPrefs.Save();
        ui.dataText.text = "Your number is " + ui.intToSave.ToString();
        Debug.Log("Game data saved!");

    }

    public void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedInteger"))
        {
            {
                ui.intToSave = PlayerPrefs.GetInt("SavedInteger");
                ui.floatToSave = PlayerPrefs.GetFloat("SavedFloat");
                ui.stringToSave = PlayerPrefs.GetString("SavedString");

                ui.dataText.text = "Hello" + ui.stringToSave + ". Your integer was " + ui.intToSave.ToString() + "and your float was " + ui.floatToSave.ToString();
                ui.intSlider.value = (float)ui.intToSave;
                ui.floatSlider.value = ui.floatToSave;

                Debug.Log("Game data loaded!");
            }
        }
        else
        {
            Debug.LogError("There is no saved data!");
        }


    }
    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        ui.intToSave = 0;
        ui.floatToSave = 0.0f;
        ui.dataText.text = "Your number is " + ui.intToSave.ToString();

        ui.intSlider.value = ui.intToSave;
        ui.floatSlider.value = ui.floatToSave;
    }

}
