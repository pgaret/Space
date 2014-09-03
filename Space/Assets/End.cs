using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {

	public GUIStyle style;
	public GUIStyle secondStyle;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	void OnGUI()
	{
		Rect rect1 = new Rect(Screen.width * 2.25f / 5, Screen.height / 4, Screen.width / 6, Screen.height / 6);
		Rect rect2 = new Rect(Screen.width * 2.25f / 5, Screen.height / 2, Screen.width / 6, Screen.height / 6);
		Rect rect3 = new Rect(Screen.width * 2.25f / 5, Screen.height / 8, Screen.width / 6, Screen.height / 14);
		
		GUI.Box (rect1, "Menu", style);
		GUI.Box (rect2, "Quit", style);
		GUI.Box (rect3, "Time: "+PlayerPrefs.GetInt("My Time").ToString(), secondStyle);
		
		Vector3 pos = Input.mousePosition;
		pos.y = Screen.height - pos.y;
		
		if (Input.GetMouseButtonDown(0) && rect1.Contains(pos)) Application.LoadLevel(0);
		if (Input.GetMouseButtonDown(0) && rect2.Contains(pos)) Application.Quit();
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
