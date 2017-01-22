using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Counter : MonoBehaviour {

	private Text counterText;
	GameObject player;
	PlayerScript playerScript;

	void Start () {
		counterText = GetComponentInChildren <Text> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		playerScript = player.GetComponent <PlayerScript> ();
	}

	void Update () {
		counterText.text = "" + playerScript.numSticks;
	}
}
