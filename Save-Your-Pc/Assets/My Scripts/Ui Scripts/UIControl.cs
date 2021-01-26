using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MetaGameJam
{
    public class UIControl : MonoBehaviour
    {

        public GameObject pcCrashScreen;
        public GameObject instructionScreen;
        public GameObject objectiveScreen1;
        public GameObject objectiveScreen2;
        public GameObject trigger;
        public GameObject pauseMenu;
        public GameObject controlsMenu;
        public GameObject gameOverScr;
        

        //Level 2 stuff
        public GameObject objectiveScreenLvl2_1;

        void OnEnable()
        {
            if(SceneManager.GetActiveScene().buildIndex == 1)
            {
                Time.timeScale = 0;
            }
            else if(SceneManager.GetActiveScene().buildIndex == 2)
            {
                Time.timeScale = 1;
                ActivateLvl2ObjScr();
            }
            
        }

        void OnDisable()
        {

        }

        void Start()
        {

        }

        void Update()
        {
            if (Input.GetButtonDown("Cancel"))
            {
                if(controlsMenu.activeSelf == true)
                {
                    OnCloseControls();
                }
                else
                {
                    if (pauseMenu.activeSelf == false)
                    {
                        pauseMenu.SetActive(true);
                        Time.timeScale = 0;
                    }
                    else
                    {
                        pauseMenu.SetActive(false);
                        Time.timeScale = 1;
                    }
                }
                
            }
        }

        void SetInitialReferences()
        {

        }

        public void ClickToStory2()
        {
            pcCrashScreen.SetActive(false);
            instructionScreen.SetActive(true);
        }

        public void ClickToGamePlay()
        {
            instructionScreen.SetActive(false);
            Time.timeScale = 1;
            objectiveScreen1.SetActive(true);
            StartCoroutine(WaitToDeactivateObj1Scr());

        }

        IEnumerator WaitToDeactivateObj1Scr()
        {
            yield return new WaitForSeconds(5f);
            objectiveScreen1.SetActive(false);
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if(other.tag == "Player")
            {
                objectiveScreen2.SetActive(true);
                StartCoroutine(WaitToDeactivateObj2Scr());
            }
        }

        IEnumerator WaitToDeactivateObj2Scr()
        {
            yield return new WaitForSeconds(5f);
            objectiveScreen2.SetActive(false);
            trigger.SetActive(false);
        }

        public void Resume()
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }

        public void OnClickControls()
        {
            controlsMenu.SetActive(true);
            pauseMenu.SetActive(false);
        }

        public void OnCloseControls()
        {
            controlsMenu.SetActive(false);
            pauseMenu.SetActive(true);
        }

        //Level 2 stuff

        void ActivateLvl2ObjScr()
        {
            objectiveScreenLvl2_1.SetActive(true);
            StartCoroutine(WaitToDeactivateLvl2ObjScr());
        }

        IEnumerator WaitToDeactivateLvl2ObjScr()
        {
            yield return new WaitForSeconds(5f);
            objectiveScreenLvl2_1.SetActive(true);
            
        }

        public void GameOverScr()
        {
            gameOverScr.SetActive(true);
        }

        

    }
}

