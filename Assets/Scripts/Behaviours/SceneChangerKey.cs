using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class SceneChangerKey : MonoBehaviour {

	[Header("Clip de audio:")]
	public AudioClip backs;

	[Header("El nivel donde debemos ir:")]
	public string nivel;

	[Header("La tecla que presionamos para ir:")]
	public KeyCode tecla;

	private AudioSource audioSource;

	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	private IEnumerator OpenScene ( string escena ) {
		float fadeTime = GameObject.Find ("Canvas").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
		SceneManager.LoadScene (escena);
	}
	void Update () {
		if(Input.GetKeyDown(tecla)){
			audioSource.clip = backs;
			audioSource.Play();
			StartCoroutine(OpenScene (nivel));
		}
	}
}
