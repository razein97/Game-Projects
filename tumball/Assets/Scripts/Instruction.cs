using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instruction : MonoBehaviour {

    public static Instruction Instance;

    public GameObject InstructionUI;
    public GameObject LevelMenu;


	// Use this for initialization
	void Start () {
        Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClickShow()
    {
        InstructionUI.SetActive(true);
        LevelMenu.SetActive(false);
    }

    public void onClickHide()
    {
        InstructionUI.SetActive(false);
        LevelMenu.SetActive(true);
    }
}
