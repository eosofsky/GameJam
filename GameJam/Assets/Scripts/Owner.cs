using UnityEngine;
using System.Collections;

public class Owner : MonoBehaviour {
	GameObject stick;
	Stick stickScript;
	Animator animator;

	void Start () {
		stick = GameObject.FindGameObjectWithTag ("Stick");
		stickScript = stick.GetComponent <Stick> ();
		animator = GetComponent <Animator> ();


	}
}
