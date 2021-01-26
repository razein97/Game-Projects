using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectCollectible : MonoBehaviour
{

    private int count;
    private float startTime;
    public float winTime;
    public Text countText;
    public Text gameoverCount;
    public GameObject levelClearedUI;
    public GameObject inGameUI;
    private int sceneIndex;
    public Text timerText;
    public Text levelClearTime;


    // Use this for initialization
    void Start()
    {
        count = 50;
        SetCountText();
        startTime = Time.time;
        

    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);

            count = count - 1;
            SetCountText();

            SaveManager.Instance.state.gold++;
            SaveManager.Instance.Save();


            AudioManager.instance.Play("CollectCollectible");


        }

        if (other.gameObject.CompareTag("fall_winner"))
        {
            if (101-count >= 30)
            {
                Victory();
                AudioManager.instance.Play("LevelCompleted");
                StartCoroutine(WaitandShow());
            }else
            {
                PlayerHealth.Instance.death();
            }
        }
    }

    

    void SetCountText()
    {
        countText.text = count.ToString();
        int countdiff = 50 - count;
        gameoverCount.text = " " + countdiff.ToString();

        if (count <= 0)
        {
            Victory();
            AudioManager.instance.Play("LevelCompleted");
            StartCoroutine(WaitandShow());
        }
    }


    // Show Level Complete after x seconds
    private IEnumerator WaitandShow()
    {
        yield return new WaitForSeconds(1);
        levelClearedUI.SetActive(true);
        inGameUI.SetActive(false);
        Time.timeScale = 0;
        if (gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }


    }

   public void Victory()
    {
        float duration = Time.time - startTime;

        string minutes = ((int)duration / 60).ToString();
        string seconds = (duration % 60).ToString("f2");

        levelClearTime.text = minutes + ":" + seconds;

        int scene = SceneManager.GetActiveScene().buildIndex;

        //'Level1 time save'
        if (scene == 1)
        {

            if (SaveManager.Instance.state.level1CompleteTime == 0)
            {
                SaveManager.Instance.state.level1CompleteTime = duration;
                SaveManager.Instance.Save();
            }
            if (SaveManager.Instance.state.level1CompleteTime != 0)
            {
                float prevSavetime = SaveManager.Instance.state.level1CompleteTime;
                if (duration < prevSavetime)
                {
                    SaveManager.Instance.state.level1CompleteTime = duration;
                    SaveManager.Instance.Save();
                }
                else
                {
                    return;
                }
            }
        }

        //level 2 time save
        else if (scene == 2)
        {

            if (SaveManager.Instance.state.level2CompleteTime == 0)
            {
                SaveManager.Instance.state.level2CompleteTime = duration;
                SaveManager.Instance.Save();
            }
            if (SaveManager.Instance.state.level2CompleteTime != 0)
            {
                float prevSavetime = SaveManager.Instance.state.level2CompleteTime;
                if (duration < prevSavetime)
                {
                    SaveManager.Instance.state.level2CompleteTime = duration;
                    SaveManager.Instance.Save();
                }
                else
                {
                    return;
                }
            }
        }

        //level3 time save
        else if (scene == 3)
        {

            if (SaveManager.Instance.state.level3CompleteTime == 0)
            {
                SaveManager.Instance.state.level3CompleteTime = duration;
                SaveManager.Instance.Save();
            }
            if (SaveManager.Instance.state.level3CompleteTime != 0)
            {
                float prevSavetime = SaveManager.Instance.state.level3CompleteTime;
                if (duration < prevSavetime)
                {
                    SaveManager.Instance.state.level3CompleteTime = duration;
                    SaveManager.Instance.Save();
                }
                else
                {
                    return;
                }
            }
        }

        // level 4 time save
        else if (scene == 4)
        {
            if (SaveManager.Instance.state.level4CompleteTime == 0)
            {
                SaveManager.Instance.state.level4CompleteTime = duration;
                SaveManager.Instance.Save();
            }
            if (SaveManager.Instance.state.level4CompleteTime != 0)
            {
                float prevSavetime = SaveManager.Instance.state.level4CompleteTime;
                if (duration < prevSavetime)
                {
                    SaveManager.Instance.state.level4CompleteTime = duration;
                    SaveManager.Instance.Save();
                }
                else
                {
                    return;
                }
            }
        }

        //level 5 time save
        else if (scene == 5)
        {
            if (SaveManager.Instance.state.level5CompleteTime == 0)
            {
                SaveManager.Instance.state.level5CompleteTime = duration;
                SaveManager.Instance.Save();
            }
            if (SaveManager.Instance.state.level5CompleteTime != 0)
            {
                float prevSavetime = SaveManager.Instance.state.level5CompleteTime;
                if (duration < prevSavetime)
                {
                    SaveManager.Instance.state.level5CompleteTime = duration;
                    SaveManager.Instance.Save();
                }
                else
                {
                    return;
                }
            }
        }

        //level 6 time save
        else if (scene == 6)
        {
            if (SaveManager.Instance.state.level6CompleteTime == 0)
            {
                SaveManager.Instance.state.level6CompleteTime = duration;
                SaveManager.Instance.Save();
            }
            if (SaveManager.Instance.state.level6CompleteTime != 0)
            {
                float prevSavetime = SaveManager.Instance.state.level6CompleteTime;
                if (duration < prevSavetime)
                {
                    SaveManager.Instance.state.level6CompleteTime = duration;
                    SaveManager.Instance.Save();
                }
                else
                {
                    return;
                }
            }
        }

        //level 7 time save
        else if (scene == 7)
        {
            if (SaveManager.Instance.state.level7CompleteTime == 0)
            {
                SaveManager.Instance.state.level7CompleteTime = duration;
                SaveManager.Instance.Save();
            }
            if (SaveManager.Instance.state.level7CompleteTime != 0)
            {
                float prevSavetime = SaveManager.Instance.state.level7CompleteTime;
                if (duration < prevSavetime)
                {
                    SaveManager.Instance.state.level7CompleteTime = duration;
                    SaveManager.Instance.Save();
                }
                else
                {
                    return;
                }
            }
        }

        //level 8 time save
        else if (scene == 8)
        {
            if (SaveManager.Instance.state.level8CompleteTime == 0)
            {
                SaveManager.Instance.state.level8CompleteTime = duration;
                SaveManager.Instance.Save();
            }
            if (SaveManager.Instance.state.level8CompleteTime != 0)
            {
                float prevSavetime = SaveManager.Instance.state.level8CompleteTime;
                if (duration < prevSavetime)
                {
                    SaveManager.Instance.state.level8CompleteTime = duration;
                    SaveManager.Instance.Save();
                }
                else
                {
                    return;
                }
            }
        }

        //level 9 time save
        else if (scene == 9)
        {
            if (SaveManager.Instance.state.level9CompleteTime == 0)
            {
                SaveManager.Instance.state.level9CompleteTime = duration;
                SaveManager.Instance.Save();
            }
            if (SaveManager.Instance.state.level9CompleteTime != 0)
            {
                float prevSavetime = SaveManager.Instance.state.level9CompleteTime;
                if (duration < prevSavetime)
                {
                    SaveManager.Instance.state.level9CompleteTime = duration;
                    SaveManager.Instance.Save();
                }
                else
                {
                    return;
                }
            }
        }

        //level 10 time save
        else if (scene == 10)
        {
            if (SaveManager.Instance.state.level10CompleteTime == 0)
            {
                SaveManager.Instance.state.level10CompleteTime = duration;
                SaveManager.Instance.Save();
            }
            if (SaveManager.Instance.state.level10CompleteTime != 0)
            {
                float prevSavetime = SaveManager.Instance.state.level10CompleteTime;
                if (duration < prevSavetime)
                {
                    SaveManager.Instance.state.level10CompleteTime = duration;
                    SaveManager.Instance.Save();
                }
                else
                {
                    return;
                }
            }
        }




    }




}
