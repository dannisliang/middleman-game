using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SceneLoader : MonoBehaviour {

	public List<string> scenes = new List<string>();
	public static SceneLoader instance = null;
	
	private int nextSceneIndex;
	private int prevSceneIndex;

	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);
	}

	void Update() {
		if(Input.GetKey(KeyCode.RightArrow)) {
			Invoke ("NextScene", 0);
		}
		if(Input.GetKey(KeyCode.LeftArrow)) {
			Invoke ("PrevScene", 0);
		}
	}

	void NextScene() {
		nextSceneIndex = scenes.IndexOf (Application.loadedLevelName) + 1;
		if (scenes[nextSceneIndex] != null) {
			Application.LoadLevel (scenes[nextSceneIndex]);
		}
	}

	void PrevScene() {
		prevSceneIndex = scenes.IndexOf (Application.loadedLevelName) - 1;
		if (scenes[prevSceneIndex] != null) {
			Application.LoadLevel (scenes[prevSceneIndex]);
		}
	}
}
