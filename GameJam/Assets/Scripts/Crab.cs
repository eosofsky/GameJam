using UnityEngine;
using System.Collections;

public class Crab : MonoBehaviour {
	public float xMin;
	public float xMax;
	public float speed;
	public bool goLeft;
	
	void Update () {
		if (goLeft) {
			transform.position += Vector3.left * speed;
		} else {
			transform.position += Vector3.right * speed;
		}
		if ((transform.position.x < xMin) || (transform.position.x > xMax)) {
			goLeft = !goLeft;
		}
	}
}