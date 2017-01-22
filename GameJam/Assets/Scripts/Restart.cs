using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	public float waitTime;

	private GameObject fader;
	private Fader faderScript;

	void Start () {
		fader = GameObject.FindGameObjectWithTag ("Fader");
		faderScript = fader.GetComponent <Fader> ();
		faderScript.FadeIn ();
		StartCoroutine ("Wait");
	}

	IEnumerator Wait () {
		yield return new WaitForSeconds (waitTime);
		Application.LoadLevel ("Scene1");
	}
}
