using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

	public Transform triangle;

	bool increaseScale = false;
	float scale = .1F;

	// Use this for initialization
	void Start ()
	{
		Screen.orientation = ScreenOrientation.Landscape;
	}
	
	void OnGUI()
	{
		if (GUI.Button(new Rect(Screen.width / 4, Screen.height * 9 / 10, Screen.width / 2, Screen.height / 10), "Test")) increaseScale = true;
		else increaseScale = false;
	}
	
	
	// Update is called once per frame
	void Update ()
	{
//		triangle.transform.Rotate(Vector3.forward * Time.deltaTime * 10);
		if (increaseScale == true) triangle.transform.localScale += new Vector3(.1F, .1F, 0);
	}
}
