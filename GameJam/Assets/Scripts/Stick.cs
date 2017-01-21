using UnityEngine;
using System.Collections;

public class Stick : MonoBehaviour {
	public float xMin;
	public float xMax;
	public float zMin;
	public float zMax;

	void Start () {
		Throw();
	}

	public void Throw () {
		float width = xMax - xMin;
		float height = zMax - zMin;
		float x = Random.value * width + xMin;
		float z = Random.value * height + zMin;
		transform.position = new Vector3 (x, 0, z);
	}
}
