using UnityEngine;
using System.Collections;

public class activatePacMan : MonoBehaviour {

	IEnumerator Wait(){
		yield return new WaitForSeconds (5.0f); //waiting to fade, so it doesnt happen the second you go outside
		float fadeTime = GameObject.Find ("Pac-man Trigger").GetComponent<fader>().BeginFade (1);
		yield return new WaitForSeconds (fadeTime); //fading
		yield return new WaitForSeconds (5.0f); //this last one is for dramatic effect
		Application.LoadLevel("levelOne");
	}
	void OnTriggerEnter(Collider other)
	{
		StartCoroutine(Wait());
	}
}
