﻿using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			Application.LoadLevel ("Scene1");
		}
	}
}
