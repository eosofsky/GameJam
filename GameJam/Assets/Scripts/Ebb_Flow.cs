using UnityEngine;
using System.Collections;

public class Ebb_Flow : MonoBehaviour {
	bool isNewWave = true;
	float startPoint = (float) 0.0;
	float translation = (float) 0.0;
	float delta = (float) 0.1;

	static float getRandomNumber() {
		return (float) (Random.Range (20, 50) / 10.0);
	}

	void Update() {
		if (isNewWave) {
			startPoint = GameObject.Find("WaveOne").transform.position.z;
			translation = getRandomNumber();
			isNewWave = false;
		}
		float currentPoint = transform.position.z;
		float distanceTraveled = currentPoint-startPoint;

		Debug.Log(string.Format("Target: {3}, CurrentPoint: {0}, Traveled:{1}, StartPoint:{2}",currentPoint, distanceTraveled, startPoint, translation));

		Debug.Log ("Before Condition");
		if (currentPoint < translation || currentPoint > startPoint) {
			if (currentPoint > startPoint) {
				isNewWave = true;
			}
			// Move backwards until collide with other wave, then go to the very back
			delta = delta * (-1);
			transform.Translate (0, 0, delta);
		} else {
			Debug.Log (string.Format ("Let's move {0} units forward!", delta));
			transform.Translate (0, 0, delta);
		}
		Debug.Log ("After Condition");
	}
}