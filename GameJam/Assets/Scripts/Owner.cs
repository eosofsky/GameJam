using UnityEngine;
using System.Collections;

public class Owner : MonoBehaviour {
	GameObject stick;
	Stick stickScript;
	Animator animator;
	public AudioClip ownerThrow;

	AudioSource throwAS;


	void Start () {
		stick = GameObject.FindGameObjectWithTag ("Stick");
		stickScript = stick.GetComponent <Stick> ();
		animator = GetComponent <Animator> ();
		throwAS = GetComponent<AudioSource> ();
		Throw ();
	}

	//void Update () {
	//	if (Input.GetButtonDown ("Jump")) {
	//		Throw ();
	//	}
	//}

	public void Throw () {
		Vector3 pos = transform.position;
		pos.z += 2.36f;
		stick.transform.position = pos;
		throwAS.PlayOneShot(ownerThrow);
		animator.SetTrigger ("Throw");
		stickScript.isFlying = true;
	}
}
