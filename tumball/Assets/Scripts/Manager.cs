using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Manager : MonoBehaviour {
   

	public static Manager Instance { set; get;  }
    public Text l1Time;
    public Text l2Time;
    public Text l3Time;
    public Text l4Time;
    public Text l5Time;
    public Text l6Time;
    public Text l7Time;
    public Text l8Time;
    public Text l9Time;
    public Text l10Time;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Instance = this;
        l1bestClearTime();
        l2bestClearTime();
        l3bestClearTime();
        l4bestClearTime();
        l5bestClearTime();
        l6bestClearTime();
        l7bestClearTime();
        l8bestClearTime();
        l9bestClearTime();
        l10bestClearTime();

    }

    public int currentLevel = 0; //Used when changing from menu to game scene
    public int menuFocus = 0;  // used when entering the menu scene 

    void l1bestClearTime()
    {
        float duration = SaveManager.Instance.state.level1CompleteTime;

        string minutes = ((int)duration / 60).ToString();
        string seconds = (duration % 60).ToString("f2");

        l1Time.text = minutes + ":" + seconds;
    }

    void l2bestClearTime()
    {
        float duration = SaveManager.Instance.state.level2CompleteTime;

        string minutes = ((int)duration / 60).ToString();
        string seconds = (duration % 60).ToString("f2");

        l2Time.text = minutes + ":" + seconds;
    }

    void l3bestClearTime()
    {
        float duration = SaveManager.Instance.state.level3CompleteTime;

        string minutes = ((int)duration / 60).ToString();
        string seconds = (duration % 60).ToString("f2");

        l3Time.text = minutes + ":" + seconds;
    }

    void l4bestClearTime()
    {
        float duration = SaveManager.Instance.state.level4CompleteTime;

        string minutes = ((int)duration / 60).ToString();
        string seconds = (duration % 60).ToString("f2");

        l4Time.text = minutes + ":" + seconds;
    }

    void l5bestClearTime()
    {
        float duration = SaveManager.Instance.state.level5CompleteTime;

        string minutes = ((int)duration / 60).ToString();
        string seconds = (duration % 60).ToString("f2");

        l5Time.text = minutes + ":" + seconds;
    }

    void l6bestClearTime()
    {
        float duration = SaveManager.Instance.state.level6CompleteTime;

        string minutes = ((int)duration / 60).ToString();
        string seconds = (duration % 60).ToString("f2");

        l6Time.text = minutes + ":" + seconds;
    }

    void l7bestClearTime()
    {
        float duration = SaveManager.Instance.state.level7CompleteTime;

        string minutes = ((int)duration / 60).ToString();
        string seconds = (duration % 60).ToString("f2");

        l7Time.text = minutes + ":" + seconds;
    }

    void l8bestClearTime()
    {
        float duration = SaveManager.Instance.state.level8CompleteTime;

        string minutes = ((int)duration / 60).ToString();
        string seconds = (duration % 60).ToString("f2");

        l8Time.text = minutes + ":" + seconds;
    }

    void l9bestClearTime()
    {
        float duration = SaveManager.Instance.state.level9CompleteTime;

        string minutes = ((int)duration / 60).ToString();
        string seconds = (duration % 60).ToString("f2");

        l9Time.text = minutes + ":" + seconds;
    }

    void l10bestClearTime()
    {
        float duration = SaveManager.Instance.state.level10CompleteTime;

        string minutes = ((int)duration / 60).ToString();
        string seconds = (duration % 60).ToString("f2");

        l10Time.text = minutes + ":" + seconds;
    }

}

