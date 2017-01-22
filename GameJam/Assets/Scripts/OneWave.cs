using UnityEngine;
using System.Collections;

public class OneWave : MonoBehaviour {

	public AudioClip dogSqueal;
	AudioSource squealAS;


	// Use this for initialization
	void OnTriggerEnter () {
		squealAS = GetComponent<AudioSource> ();
		float dissapear = (float)-30;
		squealAS.PlayOneShot(dogSqueal);
		GameObject.Find ("Dog").transform.Translate (dissapear, dissapear, dissapear);
		Application.LoadLevel ("End");
	}
}
