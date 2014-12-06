using UnityEngine;
using System.Collections;

public class lowbeatCrowd : MonoBehaviour {

	float depTime = 30.0f;
	bool played2 = false;
	
	public AudioSource sound1;
	
	void OnTriggerEnter(Collider other){
		Debug.Log ("toilet triggered");
		audio.volume = 7;
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
		audio.volume = 7;
		audio.pitch = depTime*8;
		
	}
}