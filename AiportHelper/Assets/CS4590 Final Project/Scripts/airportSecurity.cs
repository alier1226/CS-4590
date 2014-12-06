using UnityEngine;
using System.Collections;

public class airportSecurity : MonoBehaviour {

	public AudioSource security;
	
	void OnTriggerEnter(Collider other){
		Debug.Log (" triggered");
		//security.volume = 5;
		security.Play();	
	}
	void OnTriggerExit(Collider other){
		security.Stop ();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//security.volume = 5;
	}
}
