using UnityEngine;
using System.Collections;

public class Fader : MonoBehaviour {

	private Animator animator;

	void Start () {
		animator = GetComponentInChildren <Animator> ();
	}

	public void FadeIn () {
		animator.SetTrigger ("FadeIn");
	}

	public void FadeOut () {
		animator.SetTrigger ("FadeOut");
	}
}
