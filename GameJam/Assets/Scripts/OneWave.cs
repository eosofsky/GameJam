using UnityEngine;
using System.Collections;

public class OneWave : MonoBehaviour {

	public float waitTime;
	public AudioClip dogSqueal;
	AudioSource squealAS;

	private GameObject fader;
	private Fader faderScript;

	void Start () {
		fader = GameObject.FindGameObjectWithTag ("Fader");
		faderScript = fader.GetComponent <Fader> ();
	}

	void OnTriggerEnter () {
		squealAS = GetComponent<AudioSource> ();
		float dissapear = (float)-30;
		squealAS.PlayOneShot(dogSqueal);
		GameObject.Find ("Dog").transform.Translate (dissapear, dissapear, dissapear);
		StartCoroutine ("End");
	}
	
	IEnumerator End () {
		faderScript.FadeOut ();
		yield return new WaitForSeconds (waitTime);
		Application.LoadLevel ("End");
	}
}
