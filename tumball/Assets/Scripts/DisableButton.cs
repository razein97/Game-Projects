using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisableButton : MonoBehaviour {

    public Button volumeButton;
    public Sprite blockA;
    public Sprite blockA_disable;
    private bool button;

	// Use this for initialization
	void Start () {

        if (button == false)
        {
            volumeButton.image.overrideSprite = blockA;
        }
        else
        {
            volumeButton.image.overrideSprite = blockA_disable;
        }

    }
    
    void LateUpdate()
    {
        if (button == false)
        {
            volumeButton.image.overrideSprite = blockA;
        }
        else
        {
            volumeButton.image.overrideSprite = blockA_disable;
        }
    }
	public void changeButton()
    {
        if(button == false)
        {
            volumeButton.image.overrideSprite = blockA_disable;
            AudioListener.volume = 0.0f;
            button = true;
            SaveManager.Instance.Save();
        }
        else
        {
            volumeButton.image.overrideSprite = blockA;
            AudioListener.volume = 1.0f;
            button = false;
            SaveManager.Instance.Save();
        }
    }

    
}
