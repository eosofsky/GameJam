using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	GameObject owner;
	Owner ownerScript;
	GameObject player;
	PlayerScript playerScript;

	public AudioClip stickCollect;
	AudioSource stickAS;

	// Use this for initialization
	void Start () {
		stickAS = GetComponent<AudioSource> ();
		owner = GameObject.FindGameObjectWithTag ("Owner");
		ownerScript = owner.GetComponent <Owner> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		playerScript = player.GetComponent <PlayerScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerScript.hasStick) {
			playerScript.hasStick = false;
			stickAS.PlayOneShot (stickCollect);
			StartCoroutine ("waitHalfSeconds");
		}
	}
	IEnumerator waitHalfSeconds() {
		yield return new WaitForSeconds (0.5f);
		ownerScript.Throw ();
		}
	}
