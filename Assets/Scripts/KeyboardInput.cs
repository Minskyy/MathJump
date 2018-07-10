using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class KeyboardInput : NetworkBehaviour {

	public TextMesh tmesh;
	// Use this for initialization
	void Start () {
		//tmesh = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {

		if (!isLocalPlayer)
		{
			return;
		}

		if(Input.GetKeyDown (KeyCode.Keypad0) || Input.GetKeyDown (KeyCode.Alpha0)){
			tmesh.text += "0";
		}
		else if(Input.GetKeyDown (KeyCode.Keypad1) || Input.GetKeyDown (KeyCode.Alpha1)){
			tmesh.text += "1";
		}
		else if(Input.GetKeyDown (KeyCode.Keypad2) || Input.GetKeyDown (KeyCode.Alpha2)){
			tmesh.text += "2";
		}
		else if(Input.GetKeyDown (KeyCode.Keypad3)|| Input.GetKeyDown (KeyCode.Alpha3)){
			tmesh.text += "3";
		}
		else if(Input.GetKeyDown (KeyCode.Keypad4) || Input.GetKeyDown (KeyCode.Alpha4)){
			tmesh.text += "4";
		}
		else if(Input.GetKeyDown (KeyCode.Keypad5) || Input.GetKeyDown (KeyCode.Alpha5)){
			tmesh.text += "5";
		}
		else if(Input.GetKeyDown (KeyCode.Keypad6) || Input.GetKeyDown (KeyCode.Alpha6)){
			tmesh.text += "6";
		}
		else if(Input.GetKeyDown (KeyCode.Keypad7) || Input.GetKeyDown (KeyCode.Alpha7)){
			tmesh.text += "7";
		}
		else if(Input.GetKeyDown (KeyCode.Keypad8) || Input.GetKeyDown (KeyCode.Alpha8)){
			tmesh.text += "8";
		}
		else if(Input.GetKeyDown (KeyCode.Keypad9) || Input.GetKeyDown (KeyCode.Alpha9)){
			tmesh.text += "9";
		}
	}
}
