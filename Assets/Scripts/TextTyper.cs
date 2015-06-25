using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextTyper : MonoBehaviour {

	public float letterPause = 0.2f;
	public AudioClip key1;
	public AudioClip key2;
	public AudioClip key3;
	public AudioClip key4;
	public AudioClip key5;

	string message;
	Text textComp;

	// Use this for initialization
	void Start () {
		string[] wat;
		textComp = GetComponent<Text>();
		message = textComp.text;
		wat = message.Split('\n');
		textComp.text = "";
		StartCoroutine(TypeText ());
	}

	IEnumerator TypeText () {
		foreach (char letter in message.ToCharArray()) {
			textComp.text += letter;
			if (key1 && key2 && key3 && key4 && key5)
				SoundManager.instance.RandomizeSfx(key1, key2, key3, key4, key5);
				yield return 0;
			yield return new WaitForSeconds (letterPause);
		}
	}
}
