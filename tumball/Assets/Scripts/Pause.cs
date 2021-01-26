using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public static Pause Instance;

    public GameObject ingameUI;
    public GameObject pauseUI;
    public GameObject adUI;
    public GameObject gameOverUI;
    private bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused && gameOverUI.activeSelf == false)
            {

                pause();


            }
            else if (isPaused == true)
            {
                play();
            }

        }
    }

    private void Start()
    {
        Instance = this;
    }

    public void pause()
    {
        Time.timeScale = 0;
        ingameUI.SetActive(false);
        pauseUI.SetActive(true);
        isPaused = true;

    }

    public void play()
    {
        Time.timeScale = 1;
        ingameUI.SetActive(true);
        pauseUI.SetActive(false);
        isPaused = false;
    }


    public void closeAd()
    {
        adUI.SetActive(false);
        gameOverUI.SetActive(true);
    }
    
}
