using UnityEngine;
using System.Collections;

public class OneWave : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter () {
		float dissapear = (float)-30;
		GameObject.Find ("Dog").transform.Translate (dissapear, dissapear, dissapear);
	}
}
