using UnityEngine;
using System.Collections;

public class UIScript : MonoBehaviour {
	GUISkin customSkin;

	void OnGUI () {
		GUI.skin = customSkin;
		print (GUI.skin);
		// Make a background box
		GUI.Box(new Rect(25,25,200, 350), "");
		GUI.Label (new Rect (95, 45, 300, 50), "Flappy Wars!");
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(65,75,130,50), "Local 2 Player")) {
			Application.LoadLevel(1);
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(65,145,130,50), "Online Multiplayer")) {
			//Application.LoadLevel(2);
		}
	}
}

