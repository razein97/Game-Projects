using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MetaGameJam
{
    public class Control_Manager : MonoBehaviour
    {


        //private All_Input_Keys allInputKeys;

        private KeyCode newKey;
        public bool isWaitingForInput;
        Event keyEvent;
        public bool isJoystickInputDetected;
        public bool isKeyBoardInputDetected;

        [Header("Button Texts")]
        public Text forwardText;
        public Text backwardText;
        public Text fireText;
        public Text jumpText;

        [Header("Keyboard & Mouse Input")]
        public KeyCode forward;
        public KeyCode backward;
        public KeyCode fire;
        public KeyCode jump;

        //[Header("XBONE Input")]
        //public string forward_backward_G;
        //public string left_right_G;
        //public KeyCode action_G;

        void OnEnable()
        {
            SetInitialReferences();
        }

        void Start()
        {
            AssignKeys();
            isWaitingForInput = false;
            // isJoystickInputDetected = false;
            isKeyBoardInputDetected = true;
            UpdateUI();
        }

        void Update()
        {
            //CheckJoystickInput();
            //CheckKeyboardInput();
        }


        void SetInitialReferences()
        {
            //allInputKeys = GetComponent<All_Input_Keys>();

        }



        //This function assigns keys to the various keycodes
        public void AssignKeys()
        {
            //Keyboard and mouse
            forward = (KeyCode)System.Enum.Parse(typeof(KeyCode), SaveManager.Instance.state.Forward);
            backward = (KeyCode)System.Enum.Parse(typeof(KeyCode), SaveManager.Instance.state.Backward);
            fire = (KeyCode)System.Enum.Parse(typeof(KeyCode), SaveManager.Instance.state.Fire);
            jump = (KeyCode)System.Enum.Parse(typeof(KeyCode), SaveManager.Instance.state.Jump);

            //Joystick
            //forward_backward_G = SaveManager.Instance.state.Forward_Backward_G;
            //left_right_G = SaveManager.Instance.state.Right_Left_G;
            //action_G = (KeyCode)System.Enum.Parse(typeof(KeyCode), SaveManager.Instance.state.Action_G);
        }

        //This function updates the UI after new values are set
        void UpdateUI()
        {
            forwardText.text = forward.ToString();
            backwardText.text = backward.ToString();
            fireText.text = fire.ToString();
            jumpText.text = jump.ToString();
        }

        //These functions takes in the key and assigns it to the keycode newKey
        void OnGUI()
        {
            keyEvent = Event.current;
            if (keyEvent != null)
            {
                if (keyEvent.isKey && isWaitingForInput == true)
                {
                    newKey = keyEvent.keyCode;
                    isWaitingForInput = false;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }
            }
        }

        public void StartAssignment(string keyname)
        {
            if (!isWaitingForInput)
            {
                StartCoroutine(AssignKey(keyname));
            }
        }

        IEnumerator WaitForKey()
        {

            while (!keyEvent.isKey)
            {
                yield return null;
            }
        }

        public IEnumerator AssignKey(string keyName)
        {
            isWaitingForInput = true;
            yield return WaitForKey();

            switch (keyName)
            {
                case "forward":
                    forward = newKey;
                    forwardText.text = forward.ToString();
                    SaveManager.Instance.state.Forward = forward.ToString();
                    break;
                case "backward":
                    backward = newKey;
                    backwardText.text = backward.ToString();
                    SaveManager.Instance.state.Backward.ToString();
                    break;
                case "fire":
                    fire = newKey;
                    fireText.text = fire.ToString();
                    SaveManager.Instance.state.Fire.ToString();
                    break;
                case "jump":
                    jump = newKey;
                    jumpText.text = jump.ToString();
                    SaveManager.Instance.state.Jump.ToString();
                    break;
            }

            yield return null;
        }

        //This function will save the whole save which retains the user prefs
        public void ApplyControlKeys()
        {
            SaveManager.Instance.Save();
        }

        //This functions controls the blink text
        public void Blink(Text txt)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            StartCoroutine(blink(txt));
        }

        IEnumerator blink(Text txt)
        {
            for (int i = 0; i < 9999; i++)
            {
                if (isWaitingForInput == true)
                {
                    yield return new WaitForSeconds(0.5f);
                    txt.text = "_";
                    yield return new WaitForSeconds(0.5f);
                    txt.text = "";
                }
                else
                {
                    txt.text = newKey.ToString();
                    break;
                }
            }
        }

        public void LoadDefaults()
        {
            //Assigns the default values
            forward = (KeyCode)System.Enum.Parse(typeof(KeyCode), SaveManager.Instance.state.Forward_Default);
            backward = (KeyCode)System.Enum.Parse(typeof(KeyCode), SaveManager.Instance.state.Backward_Default);
            fire = (KeyCode)System.Enum.Parse(typeof(KeyCode), SaveManager.Instance.state.Fire_Default);
            jump = (KeyCode)System.Enum.Parse(typeof(KeyCode), SaveManager.Instance.state.Jump_Default);

            UpdateUI();

            //Overwrite values in Save
            SaveManager.Instance.state.Forward = SaveManager.Instance.state.Forward_Default;
            SaveManager.Instance.state.Backward = SaveManager.Instance.state.Backward_Default;
            SaveManager.Instance.state.Jump = SaveManager.Instance.state.Jump_Default;
            SaveManager.Instance.state.Fire = SaveManager.Instance.state.Fire_Default;
        }

        //void CheckJoystickInput()
        //{
        //    if(Input.GetAxis("LeftJoystickX") != 0 || Input.GetAxis("LeftJoystickY") != 0
        //        || Input.GetAxis("RightJoystickX") != 0 || Input.GetAxis("RightJoystickY") != 0
        //        || Input.GetAxis("LeftTrigger") != 0 || Input.GetAxis("RightTrigger") != 0
        //        || Input.GetAxis("DPadX") != 0 || Input.GetAxis("DPadY") != 0)
        //    {
        //        isJoystickInputDetected = true;
        //        isKeyBoardInputDetected = false;
        //    }

        //    foreach(string joyInput in allInputKeys.joyinput)
        //    {
        //        if(Input.GetKey((KeyCode)System.Enum.Parse(typeof(KeyCode), joyInput)))
        //        {
        //            isJoystickInputDetected = true;
        //            isKeyBoardInputDetected = false;
        //        }
        //    }
        //}

        //void CheckKeyboardInput()
        //{
        //    foreach(string keyInput in allInputKeys.mkinput)
        //    {
        //        if (Input.GetKey((KeyCode)System.Enum.Parse(typeof(KeyCode), keyInput)))
        //        {
        //            isKeyBoardInputDetected = true;
        //            isJoystickInputDetected = false;
        //        }
        //    }
        //}



    }

}
