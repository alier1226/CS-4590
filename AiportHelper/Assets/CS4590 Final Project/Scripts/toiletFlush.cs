using UnityEngine;
using System.Collections;

public class toiletFlush : MonoBehaviour {
	
	public AudioSource toilet;
	
	void OnTriggerEnter(Collider other){
		Debug.Log ("toilet triggered");
		toilet.Play();	
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
