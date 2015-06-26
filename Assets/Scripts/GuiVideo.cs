using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GuiVideo : MonoBehaviour {

	private AudioSource sound;

	void Start() {
		MovieTexture movie = GetComponent<RawImage>().texture as MovieTexture;
		sound = GetComponent<AudioSource>();
		sound.clip = movie.audioClip;
		movie.Play();
		sound.Play();
	}
	
//	void Update() {
//		if (!sound.isPlaying) {
//			SceneLoader.NextScene();
//		}
//	}
}
