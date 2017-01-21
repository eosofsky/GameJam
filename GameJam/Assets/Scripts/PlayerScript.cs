using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerScript : MonoBehaviour {
	public float speed;
	public float rotationSize;

	private CharacterController controller;
	private Vector3 moveDirection = Vector3.zero;
	private Animator anim;

	void Start () {
		controller = GetComponent<CharacterController> ();
		anim = GetComponent<Animator> ();
	}

	void Update () {
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");

		Move (x,z);
		Rotate (x,z);
		Animating (x,z);
	}

	void Move (float x, float z) {
		moveDirection = new Vector3 (x, 0, z);
		moveDirection = transform.TransformDirection (moveDirection);
		moveDirection *= speed;
		controller.Move (moveDirection * Time.deltaTime);
	}	

	void Rotate (float x, float z) {
		//bool rotateLeft = (x < 0.0f) && (z > 0.0f);
		//bool rotateRight = (x > 0.0f) && (z > 0.0f);
		//if (rotateRight) {
		//	transform.eulerAngles = new Vector3 (rotationSize, rotationSize, 0);
		//} else if (rotateLeft) {
		//	transform.eulerAngles = new Vector3 (rotationSize, -rotationSize, 0);
		//} else {
		//	transform.eulerAngles = new Vector3 (0, 0, 0);
		//}
	}

	void Animating (float x, float z) {
		bool forwards = (z > 0f);
		anim.SetBool ("Forwards", forwards);
	}
}
