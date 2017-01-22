using UnityEngine;
using System.Collections;

public class Stick : MonoBehaviour {
	public float xMin;
	public float xMax;
	public float zMin;
	public float zMax;
	public Transform target;
	public bool isFlying;
	public float speed;

	private Animator animator;

	void Start () {
		animator = GetComponent <Animator> ();
	}

	void Update () {
		if (isFlying) {
			transform.position = Vector3.Lerp (transform.position, target.position, speed);
			if (gameObject.transform.position.z >= zMin) {
				isFlying = false;
				Land();
			}
		}
		animator.SetBool ("IsFlying", isFlying);
	}

	void Land () {
		float width = xMax - xMin;
		float height = zMax - zMin;
		float x = Random.value * width + xMin;
		float z = Random.value * height + zMin;
		transform.position = new Vector3 (x, 0, z);
	}
}
