using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerScript : MonoBehaviour {
	public float speed;

	private CharacterController controller;
	private Vector3 moveDirection = Vector3.zero;

	void Start () {
		controller = GetComponent<CharacterController> ();
	}

	void Update () {
		Move ();
	}

	void Move () {
		moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		moveDirection = transform.TransformDirection (moveDirection);
		moveDirection *= speed;
		controller.Move (moveDirection * Time.deltaTime);
	}
}
