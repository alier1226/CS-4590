using UnityEngine;
using System.Collections;

public class trainAnn : MonoBehaviour {

	public AudioSource sound1;

	
	void OnTriggerEnter(Collider other){
		Debug.Log ("trigger");
		sound1.Play ();
		//comeIn = false;
	}
	void OnTriggerExit(Collider other){
		Debug.Log ("out");
		sound1.Stop();
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}