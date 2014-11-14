using UnityEngine;
using System.Collections;

public class BackgroundMusic : MonoBehaviour {
	
	public AudioSource backgroundMusic;
	public AudioSource raining;

	bool comeIn = true;

	void OnTriggerEnter(Collider other){
		Debug.Log ("Customer enters");
		backgroundMusic.Play();
		raining.Stop();
		//comeIn = false;
		}
	void OnTriggerExit(Collider other){
		Debug.Log ("Customer exits");
		backgroundMusic.Stop();
		raining.Play ();
		}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
