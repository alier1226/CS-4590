using UnityEngine;
using System.Collections;

public class beatCrowded : MonoBehaviour {
	public AudioClip clip1;
	public AudioClip clip2;
	float depTime = 30.0f;
	bool played2 = false;

	public AudioSource sound1;
	
	void OnTriggerEnter(Collider other){
		Debug.Log ("toilet triggered");
		audio.volume = 8;
		sound1.Play();	
	}
	void OnTriggerExit(Collider other){
		sound1.Stop ();
	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		audio.volume = 8;
			audio.pitch = depTime*5;
			
		}
	}

