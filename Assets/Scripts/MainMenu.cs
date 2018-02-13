using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public Texture background;

	void OnGUI() {
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), background);
	}
		
	void Update () {
		// Our flex equivalent to start game
		if (Input.GetKeyDown ("space")) {
			SceneManager.LoadScene (1);
		}
		// Hit escape from Main Menu and it closes the game
		if (Input.GetKeyDown(KeyCode.Escape)) {
			// Standalone:
			// Application.Quit();
			// Unity Editor:
			// UnityEditor.EditorApplication.isPlaying = false;
			// WebGL:
			Application.OpenURL("about:blank");
		}
	}
}
