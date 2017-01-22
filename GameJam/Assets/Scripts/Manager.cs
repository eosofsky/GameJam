using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	GameObject owner;
	Owner ownerScript;
	GameObject player;
	PlayerScript playerScript;

	// Use this for initialization
	void Start () {
		owner = GameObject.FindGameObjectWithTag ("Owner");
		ownerScript = owner.GetComponent <Owner> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		playerScript = player.GetComponent <PlayerScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerScript.hasStick) {
			playerScript.hasStick = false;
			ownerScript.Throw ();
		}
	}
}
