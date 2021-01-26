using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour {

   // public SceneFader fader;

    public Button[] levelButtons;


    void Start()
    {

        //level unlock according to number of coins

    int unlock = SaveManager.Instance.state.gold;

        if (unlock < 50)
        {
            levelButtons[1].interactable = false;
        }
        else
        {
            levelButtons[1].interactable = true;
        }
        if (unlock < 100)
        {
            levelButtons[2].interactable = false;
        }
        else
        {
            levelButtons[2].interactable = true;
        }
        if (unlock < 150)
        {
            levelButtons[3].interactable = false;
        }
        else
        {
            levelButtons[3].interactable = true;
        }
        if (unlock < 200)
        {
            levelButtons[4].interactable = false;
        }
        else
        {
            levelButtons[4].interactable = true;
        }
        if (unlock < 250)
        {
            levelButtons[5].interactable = false;
        }
        else
        {
            levelButtons[5].interactable = true;
        }
        if (unlock < 300)
        {
            levelButtons[6].interactable = false;
        }
        else
        {
            levelButtons[6].interactable = true;
        }
        if (unlock < 350)
        {
            levelButtons[7].interactable = false;
        }
        else
        {
            levelButtons[7].interactable = true;
        }
        if (unlock < 400)
        {
            levelButtons[8].interactable = false;
        }
        else
        {
            levelButtons[8].interactable = true;
        }
        if (unlock < 450)
        {
            levelButtons[9].interactable = false;
        }
        else
        {
            levelButtons[9].interactable = true;
        }

    }

   /* public void Select (string levelName)
    {
        fader.FadeTo(levelName);
    } */

   
}
