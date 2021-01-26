using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScene : MonoBehaviour {

    public RectTransform menuContainer;
    public Transform levelPanel;
    public Text lifeText;
    public Text goldText;

    private bool a = true;



    private Vector3 desiredMenuPosition;

    private void Start()
    {
        //position our camera on the focused menu
        SetCameraTo(Manager.Instance.menuFocus);

        //instruction
        if(SaveManager.Instance.state.inst == true)
        {
            Instruction.Instance.onClickShow();
            SaveManager.Instance.state.inst = false;
            SaveManager.Instance.Save();
        }

        
        //Add button on-click events to levels
       // InitLevel();
    }

    private void Update()
    {
        // Update all  text on screen 
        UpdateMenuText();
        //Menu navigation smooth 
        menuContainer.anchoredPosition3D = Vector3.Lerp(menuContainer.anchoredPosition3D, desiredMenuPosition, 0.2f);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (a == true)
            {
                if (SceneManager.GetActiveScene().buildIndex == 0)
                {
                    a = false;
                    NavigateTo(0);
                    return;
                }
            }
            else if (a == false)
            {
                if (SceneManager.GetActiveScene().buildIndex == 0)
                {
                    Application.Quit();
                }
            }
        }
    }


   /* private void InitLevel()
    {
        if (levelPanel == null)
        {
            Debug.Log("You did not assign the panel in the inspector");
        }
        //for every children transform under our level panel, find button  and add onClick
        int i = 0;
        foreach (Transform t in levelPanel)
        {
            int currentIndex = i;

            Button b = t.GetComponent<Button>();
            b.onClick.AddListener(() => OnLevelSelect(currentIndex)); 

            Image img = t.GetComponent<Image>();
            
            //Is it unlocked
            if (i <= SaveManager.Instance.state.completedLevel)
            {
                // it is unlocked
                if (i == SaveManager.Instance.state.completedLevel)
                {
                    //its not completed
                    img.color = Color.white;
                }
                else
                {
                    // level is already completed
                    img.color = Color.green;
                }
            }
            else
            {
                //Level isnt unlocked, disable the button
                b.interactable = false;

                // Set to a dark color
                img.color = Color.grey;

            }

            i++;
        }
    }
    */

    private void UpdateMenuText()
    {
        goldText.text = SaveManager.Instance.state.gold.ToString();
        lifeText.text = SaveManager.Instance.state.levelLife.ToString();
    }

    private void SetCameraTo(int menuIndex)
    {
        NavigateTo(menuIndex);
        menuContainer.anchoredPosition3D = desiredMenuPosition;
    }

    private void NavigateTo(int menuIndex)
    {
        
        switch (menuIndex){
            //0 && default case = Main Menu
            default:
            case 0:
                desiredMenuPosition = Vector3.zero;
                break;
            // 1 = Play Menu
            case 1:
                desiredMenuPosition = Vector3.right * 1920;
                break;
                
        }
    }

    //Button 
   public void OnPlayClick()
    {
        NavigateTo(1);
        Time.timeScale = 1;
        Debug.Log("Play is clicked.");
    }
    
   /* public void OnLevelSelect1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnLevelSelect2()
    {
        SceneManager.LoadScene("Level2");
        Debug.Log("Level 2 Selected");
    }

   /* private void OnLevelSelect(int currentIndex)
    {
        Manager.Instance.currentLevel = currentIndex;
        SceneManager.LoadScene("Level1");
        Debug.Log("Selecting Level : " + currentIndex);
    }
    */

    public void OnBackClick()
    {
        NavigateTo(0);
        Debug.Log("Back button has been clicked");
    }

}
