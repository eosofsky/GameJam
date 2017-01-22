using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerScript : MonoBehaviour {
	public float speed;
	public bool hasStick;

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

		Animating (x,z);
		Move (x,z);
		Rotate (x,z);
	}

	void Move (float x, float z) {
		moveDirection = new Vector3 (x, 0.0f, z);
		//moveDirection = transform.TransformDirection (moveDirection);
		moveDirection *= speed;
		//moveDirection.y = 0.0f;
		controller.Move (moveDirection * Time.deltaTime);
		Vector3 pos = transform.position;
		pos.y = 0.0f;
		transform.position = pos;
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
		anim.SetBool ("Forwards", (z > 0.0f));
		anim.SetBool ("Backwards", (z < 0.0f));
		anim.SetBool ("Left", (x < 0.0f));
		anim.SetBool ("Right", (x > 0.0f));
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("Stick")) {
			Debug.Log ("Yum");
			//Destroy (other.gameObject);
			hasStick = true;
		} //else {
			//Debug.Log ("Yuck");
		//}
	}

	void OnControllerColliderHit () {
	//	Debug.Log ("Hi");
	}
}
