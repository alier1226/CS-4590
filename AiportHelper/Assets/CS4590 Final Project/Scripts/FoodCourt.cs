using UnityEngine;
using System.Collections;

public class FoodCourt : MonoBehaviour {
	
	
	public AudioSource foodCourt;
	
	void OnTriggerEnter(Collider other){
		Debug.Log ("triggered");
		foodCourt.Play();	
	}
	void OnTriggerExit(Collider other){
		foodCourt.Stop ();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}