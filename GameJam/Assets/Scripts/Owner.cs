using UnityEngine;
using System.Collections;

public class Owner : MonoBehaviour {
	GameObject stick;
	Stick stickScript;
	Animator animator;


	void Start () {
		stick = GameObject.FindGameObjectWithTag ("Stick");
		stickScript = stick.GetComponent <Stick> ();
		animator = GetComponent <Animator> ();
		Throw ();
	}

	//void Update () {
	//	if (Input.GetButtonDown ("Jump")) {
	//		Throw ();
	//	}
	//}

	public void Throw () {
		//Debug.Log ("throwing");
		Vector3 pos = transform.position;
		pos.z += 2.36f;
		stick.transform.position = pos;
		animator.SetTrigger ("Throw");
		stickScript.isFlying = true;
	}
}
