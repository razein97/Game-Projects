using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class All_Input_Keys : MonoBehaviour {

    public List<string> mkinput;
    public List<string> joyinput;

    void Awake()
    {

    }

	void OnEnable()
	{
        SetInitialReferences();
	}

	void OnDisable()
	{
	
	}

	void Start() 
	{
    
	}
	
	void Update() 
	{
		
	}
	
	void SetInitialReferences()
	{
        //All Keyboard and Mouse Buttons
        mkinput = new List<string>();

        mkinput.Add("Backspace");
        mkinput.Add("Delete");
        mkinput.Add("Tab");
        mkinput.Add("Clear");
        mkinput.Add("Return");
        mkinput.Add("Pause");
        mkinput.Add("Escape");
        mkinput.Add("Space");
        mkinput.Add("Keypad0");
        mkinput.Add("Keypad1");
        mkinput.Add("Keypad2");
        mkinput.Add("Keypad3");
        mkinput.Add("Keypad4");
        mkinput.Add("Keypad5");
        mkinput.Add("Keypad6");
        mkinput.Add("Keypad7");
        mkinput.Add("Keypad8");
        mkinput.Add("Keypad9");
        mkinput.Add("KeypadPeriod");
        mkinput.Add("KeypadDivide");
        mkinput.Add("KeypadMultiply");
        mkinput.Add("KeypadMinus");
        mkinput.Add("KeypadPlus");
        mkinput.Add("KeypadEnter");
        mkinput.Add("KeypadEquals");
        mkinput.Add("UpArrow");
        mkinput.Add("DownArrow");
        mkinput.Add("RightArrow");
        mkinput.Add("LeftArrow");
        mkinput.Add("Insert");
        mkinput.Add("Home");
        mkinput.Add("End");
        mkinput.Add("PageUp");
        mkinput.Add("PageDown");
        mkinput.Add("F1");
        mkinput.Add("F2");
        mkinput.Add("F3");
        mkinput.Add("F4");
        mkinput.Add("F5");
        mkinput.Add("F6");
        mkinput.Add("F7");
        mkinput.Add("F8");
        mkinput.Add("F9");
        mkinput.Add("F10");
        mkinput.Add("F11");
        mkinput.Add("F12");
        mkinput.Add("F13");
        mkinput.Add("F14");
        mkinput.Add("F15");
        mkinput.Add("Alpha0");
        mkinput.Add("Alpha1");
        mkinput.Add("Alpha2");
        mkinput.Add("Alpha3");
        mkinput.Add("Alpha4");
        mkinput.Add("Alpha5");
        mkinput.Add("Alpha6");
        mkinput.Add("Alpha7");
        mkinput.Add("Alpha8");
        mkinput.Add("Alpha9");
        mkinput.Add("Exclaim");
        mkinput.Add("DoubleQuote");
        mkinput.Add("Hash");
        mkinput.Add("Dollar");
        mkinput.Add("Ampersand");
        mkinput.Add("Quote");
        mkinput.Add("LeftParen");
        mkinput.Add("RightParen");
        mkinput.Add("Asterisk");
        mkinput.Add("Plus");
        mkinput.Add("Comma");
        mkinput.Add("Minus");
        mkinput.Add("Period");
        mkinput.Add("Slash");
        mkinput.Add("Colon");
        mkinput.Add("Semicolon");
        mkinput.Add("Less");
        mkinput.Add("Equals");
        mkinput.Add("Greater");
        mkinput.Add("Question");
        mkinput.Add("At");
        mkinput.Add("LeftBracket");
        mkinput.Add("RightBracket");
        mkinput.Add("Caret");
        mkinput.Add("Underscore");
        mkinput.Add("BackQuote");
        mkinput.Add("A");
        mkinput.Add("B");
        mkinput.Add("C");
        mkinput.Add("D");
        mkinput.Add("E");
        mkinput.Add("F");
        mkinput.Add("G");
        mkinput.Add("H");
        mkinput.Add("I");
        mkinput.Add("J");
        mkinput.Add("K");
        mkinput.Add("L");
        mkinput.Add("M");
        mkinput.Add("N");
        mkinput.Add("O");
        mkinput.Add("P");
        mkinput.Add("Q");
        mkinput.Add("R");
        mkinput.Add("S");
        mkinput.Add("T");
        mkinput.Add("U");
        mkinput.Add("V");
        mkinput.Add("W");
        mkinput.Add("X");
        mkinput.Add("Y");
        mkinput.Add("Z");
        mkinput.Add("Numlock");
        mkinput.Add("CapsLock");
        mkinput.Add("ScrollLock");
        mkinput.Add("RightShift");
        mkinput.Add("LeftShift");
        mkinput.Add("RightControl");
        mkinput.Add("LeftControl");
        mkinput.Add("RightAlt");
        mkinput.Add("LeftAlt");
        mkinput.Add("LeftCommand");
        mkinput.Add("LeftApple");
        mkinput.Add("LeftWindows");
        mkinput.Add("RightCommand");
        mkinput.Add("RightApple");
        mkinput.Add("RightWindows");
        mkinput.Add("AltGr");
        mkinput.Add("Help");
        mkinput.Add("Print");
        mkinput.Add("SysReq");
        mkinput.Add("Break");
        mkinput.Add("Menu");
        mkinput.Add("Mouse0");
        mkinput.Add("Mouse1");
        mkinput.Add("Mouse2");
        mkinput.Add("Mouse3");
        mkinput.Add("Mouse4");
        mkinput.Add("Mouse5");
        mkinput.Add("Mouse6");

        //All Joystick Buttons
        joyinput = new List<string>();

        joyinput.Add("JoystickButton0");
        joyinput.Add("JoystickButton1");
        joyinput.Add("JoystickButton2");
        joyinput.Add("JoystickButton3");
        joyinput.Add("JoystickButton4");
        joyinput.Add("JoystickButton5");
        joyinput.Add("JoystickButton6");
        joyinput.Add("JoystickButton7");
        joyinput.Add("JoystickButton8");
        joyinput.Add("JoystickButton9");
        joyinput.Add("JoystickButton10");
        joyinput.Add("JoystickButton11");
        joyinput.Add("JoystickButton12");
        joyinput.Add("JoystickButton13");
        joyinput.Add("JoystickButton14");
        joyinput.Add("JoystickButton15");
        joyinput.Add("JoystickButton16");
        joyinput.Add("JoystickButton17");
        joyinput.Add("JoystickButton18");
        joyinput.Add("JoystickButton19");

    }


    
}
