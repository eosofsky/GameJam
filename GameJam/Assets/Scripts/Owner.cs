﻿using UnityEngine;
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

	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			Throw ();
		}
	}

	void Throw () {
		Vector3 pos = transform.position;
		pos.z += 2.36f;
		stick.transform.position = pos;
		animator.SetTrigger ("Throw");
		stickScript.isFlying = true;
	}
}
