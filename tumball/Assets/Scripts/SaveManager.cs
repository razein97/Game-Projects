using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour {

    public static SaveManager Instance { set; get;  }
    public SaveState state;

    private void Awake()
    {
        //ResetSave();
        DontDestroyOnLoad(gameObject);
        Instance = this;
        Load();
        
    }


    //save the whole state of this saveState script to the player pref
    public void Save()
    {
        PlayerPrefs.SetString("save", Helper.Encrypt(Helper.Serialize<SaveState>(state)));
    }

    //Load the previous saved state from the player prefs
    public void Load()
    {
        //Do we already have a save?
        if (PlayerPrefs.HasKey("save"))
        {
            Debug.Log(PlayerPrefs.GetString("save"));
            state = Helper.Deserialize<SaveState>(Helper.Decrypt(PlayerPrefs.GetString("save")));
        }
        else
        {
            state = new SaveState();
            Save();
            Debug.Log("No save file found creating a new one");
        }
    }
	
    //Reset the whole save file 
    public void ResetSave()
    {
        PlayerPrefs.DeleteKey("save");
    }

}
