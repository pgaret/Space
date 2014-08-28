using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		Screen.orientation = ScreenOrientation.Landscape;
	}
	
	void OnGUI()
	{
		if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, Screen.width / 4, Screen.height / 4), "Test")) Debug.Log("Test");
	}
	
	
	// Update is called once per frame
	void Update ()
	{
		Debug.Log (Screen.orientation);
	}
}
