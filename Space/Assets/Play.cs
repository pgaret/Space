using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

	public Transform triangle;
	public GUIStyle fire;
	public GUIStyle water;
	public GUIStyle earth;

	float waterScale = 0;
	float earthScale = 0;
	float fireScale = 0;

	float scale = .1F;
	string text = "None";
	
	int earthInt = 0;
	int waterInt = 0;
	int fireInt = 0;
	
	bool earthBool = false;
	bool waterBool = false;
	bool fireBool = false;

	// Use this for initialization
	void Start ()
	{
		Screen.orientation = ScreenOrientation.Portrait;
	}
	
	void OnGUI()
	{
		if (GUI.RepeatButton(new Rect(-Screen.width / 70, Screen.height * 3.5f / 5, Screen.width * 18.3f / 50, Screen.height * 9 / 20), " ", earth))
		{
			text = "Earth";
			earthInt += 1;
			earthBool = true;
		}
		else earthBool = false;
		if (GUI.RepeatButton(new Rect(Screen.width * 3.27f / 10, Screen.height * 3.5f / 5, Screen.width * 18.3f / 50, Screen.height * 9 / 20), " ", fire))
		{
			text = "Fire";
			fireInt += 1;
			fireBool = true;
		}
		else fireBool = false;
		if (GUI.RepeatButton(new Rect(Screen.width * 2f / 3, Screen.height * 3.5f / 5, Screen.width * 18.3f / 50, Screen.height * 9 / 20), " ", water))
		{
			text = "Water";
			waterInt += 1;
			waterBool = true;
		}
		else waterBool = false;
	
		GUI.skin.box.alignment = TextAnchor.MiddleCenter;
		GUI.skin.box.fontSize = 48;
		GUI.Box (new Rect(Screen.width / 4, Screen.height / 4, Screen.width / 2, Screen.height / 2), earthInt.ToString()+" "+fireInt.ToString()+" "+waterInt.ToString());
	}
	
	
	// Update is called once per frame
	void Update ()
	{
//		triangle.transform.Rotate(Vector3.forward * Time.deltaTime * 10);
		
//		if (waterScale == 5) triangle.transform.localScale += new Vector3(.1F, .1F, 0);
		
		if (earthBool == false && earthInt > 0) earthInt -= 1;
		if (fireBool == false && fireInt > 0) fireInt -= 1;
		if (waterBool == false && waterInt > 0) waterInt -= 1;
	}
}
