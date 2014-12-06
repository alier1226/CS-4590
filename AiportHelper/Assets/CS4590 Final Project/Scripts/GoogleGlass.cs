using UnityEngine;
using System.Collections;

public class GoogleGlass : MonoBehaviour {
	private GUIStyle currentStyle = null;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		OnGUI ();
	}
	void OnGUI () {

		float glassH = (Screen.height / 100) * 30;
		float glassW = (Screen.width / 100) * 40;
		float spaceW = Screen.width - (glassW + 10);
		print (glassW);
		// Make a background box
		currentStyle = new GUIStyle (GUI.skin.box);
		currentStyle.normal.background = makeTextureForBox (Color.white); // makes a box style class, 
		// then you attach it to the box object. You can also make text styles and so on, and attach
		// to the corresponding objects
		//currentStyle.normal.textColor = Color.black;

		GUI.contentColor = Color.black; //<--text color
//		GUI.color = Color.white;
		GUI.Box (new Rect (spaceW,10,glassW, glassH), "Say 'Ok Glass' to start \n SFO - JFK \n Delta Airline \n On time ", currentStyle);
		int temp = (int) (1800 - Time.time);
		string time = (temp/60)+"minutes left.";
		if (temp > 600) {
			GUI.TextField (new Rect (spaceW + 5, 20, glassW - 400, glassH - 20), System.DateTime.Now.ToString()+"\nFlight Information \n" + time);
				}
		else if(temp >0){
			GUI.TextField (new Rect (spaceW + 5, 20, glassW - 400, glassH - 20),System.DateTime.Now.ToString()+"\nFlight Information \n" + time);

		} else if (temp <= 0) {
			GUI.TextField (new Rect (spaceW + 5, 20, glassW - 400, glassH - 20), System.DateTime.Now.ToString()+"\nFlight Information \n" + "It is time to check in");

		}

	}
	private Texture2D makeTextureForBox( Color col )
	{
		col.a = 0.5f;// added this to control transparency, 0.1f = 10%
		Texture2D result = new Texture2D( 1, 1 );
		Color[] px = new Color[1];
		px [0] = col;
		result.SetPixels( px );
		result.Apply();
		return result;
	}
}
