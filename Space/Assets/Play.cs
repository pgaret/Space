using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

	public GameObject triangle;
	public GameObject orangeTriangle;
	public GameObject greenTriangle;
	public GameObject blueTriangle;
	
	public Transform topCorner;
	public Transform leftCorner;
	public Transform rightCorner;
	
	public GUIStyle fire;
	public GUIStyle water;
	public GUIStyle earth;
	
	public Font font;
	
	private int startingPop = 100;
	private int minPop = 50;
	private int currentPop;

//	bool waterBool = false;
//	bool earthBool = false;
//	bool fireBool = false;
	
	Vector3 screenSize;

	// Use this for initialization
	void Start ()
	{
		for (int i = 0; i < startingPop; i++)
		{
			int random = Random.Range (0, 3);
			if (random == 0) Instantiate (orangeTriangle);
			if (random == 1) Instantiate (blueTriangle);
			if (random == 2) Instantiate (greenTriangle);
		}
		GameObject triangle = GameObject.FindGameObjectWithTag("Triangle");
	}
	
	void OnGUI()
	{	
		Rect waterRect = new Rect(-Screen.width / 70, Screen.height * 3.5f / 5, Screen.width * 18.3f / 50, Screen.height * 9 / 20);
		Rect fireRect = new Rect(Screen.width * 3.27f / 10, Screen.height * 3.5f / 5, Screen.width * 18.3f / 50, Screen.height * 9 / 20);
		Rect earthRect = new Rect(Screen.width * 2f / 3, Screen.height * 3.5f / 5, Screen.width * 18.3f / 50, Screen.height * 9 / 20);
		
		GUI.Box (waterRect, "", water);
		GUI.Box (earthRect, "", earth);
		GUI.Box (fireRect, "", fire);
		
		GUI.skin.box.font = font;
		GUI.Box (new Rect(Screen.width / 4, Screen.height / 10, Screen.width / 4, Screen.height / 10), "Current Pop: "+currentPop.ToString()+" Max Pop: "+minPop.ToString()+" Time: "+Mathf.RoundToInt(Time.time).ToString());
		
//		foreach (Touch t in Input.touches)
//		{
//			Vector3 position = t.position;
//			position.y = Screen.height - position.y;
//			if (waterRect.Contains(position))
//			{
//				GameObject.FindGameObjectWithTag("Water").GetComponent<playercontrol>().activate = true;
//				waterBool = true;
//			}
//			if (!waterRect.Contains(position) && waterBool == false) GameObject.FindGameObjectWithTag("Water").GetComponent<playercontrol>().activate = false;
//			if (earthRect.Contains(position))
//			{
//				GameObject.FindGameObjectWithTag("Earth").GetComponent<playercontrol>().activate = true;
//				earthBool = true;
//			}
//			if (!earthRect.Contains (position) && earthBool == false) GameObject.FindGameObjectWithTag("Earth").GetComponent<playercontrol>().activate = false;
//			if (fireRect.Contains(position))
//			{
//				GameObject.FindGameObjectWithTag("Fire").GetComponent<playercontrol>().activate = true;
//				fireBool = true;
//			}
//			if (!fireRect.Contains(position) && fireBool == false) GameObject.FindGameObjectWithTag("Fire").GetComponent<playercontrol>().activate = false;	
//		}

//		waterBool = false;
//		fireBool = false;
//		earthBool = false;

//		if (Input.touchCount == 0)
//		{
//			GameObject.FindGameObjectWithTag("Water").GetComponent<playercontrol>().activate = false;
//			GameObject.FindGameObjectWithTag("Earth").GetComponent<playercontrol>().activate = false;
//			GameObject.FindGameObjectWithTag("Fire").GetComponent<playercontrol>().activate = false;
//		}		
	}
	
	
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate(Vector3.forward * Time.deltaTime * 10);
		
		currentPop = GameObject.FindGameObjectsWithTag("Inhabitant").Length;
	}
}
