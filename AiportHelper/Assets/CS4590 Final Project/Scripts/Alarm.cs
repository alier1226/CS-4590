using UnityEngine;
using System.Collections;

public class Alarm : MonoBehaviour {
	public AudioClip clip1;
	public AudioClip clip2;
	float depTime = 30.0f;
	bool played2 = false;
	// Use this for initialization
	void Start () {
		audio.clip = clip1;
		audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		depTime -= Time.deltaTime;
		if (depTime > 10) {
			audio.pitch = 1+( 1 / 15.0f * (30-depTime));

		}
		else if (depTime <=10 && played2 == false){
			audio.pitch = 1;
			audio.clip = clip2;
			audio.Play();
			audio.loop = false;
			played2 = true;

		}
	}
}
