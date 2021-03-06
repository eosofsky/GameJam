﻿using UnityEngine;
using System.Collections;

public class Ebb_Flow : MonoBehaviour {
	float offset = (float) 5.1;
	bool isNewWave = true;
	float startPoint = (float) 0.0;
	float translation = (float) 0.0;
	float delta = (float) 0.0;

	static float getRandomNumber() {
		return (float) (Random.Range (5, 20) / 10.0);
	}

	void Update() {
		if (isNewWave) {
			startPoint = (float) 20.3;
			// Should get flatter as the wave bears down
			delta = (float) -0.03;
			translation = getRandomNumber() + (startPoint - offset);
			isNewWave = false;
		}
		float currentPoint = GameObject.Find("WaveOne").transform.position.z;
		float distanceTraveled = startPoint - currentPoint;

		if (distanceTraveled > translation || distanceTraveled < 0) {
			if (distanceTraveled < 0) {
				isNewWave = true;
			}
			// Move backwards until collide with other wave, then go to the very back
			delta = delta * (-1);
			GameObject.Find("WaveOne").transform.Translate (0, delta, 0);
			GameObject.Find("Ocean").transform.Translate (0, 0, delta);
		} else {
			GameObject.Find("Ocean").transform.Translate (0, 0, delta);
			GameObject.Find("WaveOne").transform.Translate (0, delta, 0);
		}
	}
}