using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MetaGameJam
{
    public class PlayerStats : MonoBehaviour
    {
        AudioManager am;
        public GameObject life1;
        public GameObject life2;
        public GameObject life3;

        public float playerHealth;

        public float numberOfLives = 3f;
        //Level 1 stuff
        public bool islevel1Objective1Completed = false;
        public bool islevel1Objective2Completed = false;
        public bool islevel1Objective3Completed = false;

        //Level 2 stuff
        public bool islevel2Objective1Completed = false;
        public bool islevel2Objective2Completed = false;

        public GameObject canvasDead;
        public GameObject level1Complete;
        public GameObject level2Complete;



        void Start()
        {
            am = GameObject.Find("AudioManager").GetComponent<AudioManager>();

            playerHealth = 100f;

            //Set the end screen to disabled if it is enabled at the start of game.
            if(level1Complete.activeSelf == true)
            {
                level1Complete.SetActive(false);
            }
        }

        void Update()
        {
            CheckIfPlayerIsDead();

            if(SceneManager.GetActiveScene().buildIndex == 1)
            {
                CheckIfPlayerHasCompletedAllObjectivesLV1();
            }else if(SceneManager.GetActiveScene().buildIndex == 2)
            {
                CheckIfPlayerHasCompletedAllObjectivesLV2();
            }

            
            

            
        }

        void CheckIfPlayerIsDead()
        {
            if(playerHealth <= 0)
            {
                numberOfLives -= 1;
                playerHealth = 100f;
                
                if(numberOfLives == 2)
                {
                    life3.SetActive(false);
                }
                else if(numberOfLives == 1)
                {
                    life2.SetActive(false);
                }
                else if(numberOfLives <= 0)
                {
                    am.Play("Player Die");
                    life1.SetActive(false);
                    Debug.Log("Player is Now Dead");
                    canvasDead.SetActive(true);
                    Time.timeScale = 0;
                }
            }

            if(numberOfLives <= 0)
            {
                am.Play("Player Die");
                life1.SetActive(false);
                Debug.Log("Player is Now Dead");
                canvasDead.SetActive(true);
                Time.timeScale = 0;
            }
        }

        void CheckIfPlayerHasCompletedAllObjectivesLV1()
        {
            if(islevel1Objective1Completed == true && islevel1Objective2Completed == true && islevel1Objective3Completed == true)
            {
                //Player Has Cleared the level
                level1Complete.SetActive(true);
                Time.timeScale = 0;
            }
        }

        void CheckIfPlayerHasCompletedAllObjectivesLV2()
        {
            if (islevel2Objective1Completed == true && islevel2Objective2Completed == true)
            {
                //Player Has Cleared the level
                level2Complete.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

}

