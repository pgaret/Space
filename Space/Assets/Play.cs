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

	public GUIStyle style;
	
	public AudioSource clip;
	
	private int startingPop = 100;
	private int minPop;
	private int currentPop;
	
	private float timer;
	private int counter = 0;
	private bool lost = false;

//	bool waterBool = false;
//	bool earthBool = false;
//	bool fireBool = false;
	
	Vector3 screenSize;

	// Use this for initialization
	void Start ()
	{
		if (Application.loadedLevel == 1) minPop = 1;
		if (Application.loadedLevel == 2) minPop = 5;
		if (Application.loadedLevel == 3) minPop = 10;
		timer = Time.time;
		GameObject triangle = GameObject.FindGameObjectWithTag("Triangle");
	}
	
	void OnGUI()
	{	
		Rect waterRect = new Rect(-Screen.width / 70, Screen.height * 3.5f / 5, Screen.width * 18.3f / 50, Screen.height * 9 / 20);
		Rect earthRect = new Rect(Screen.width * 3.27f / 10, Screen.height * 3.5f / 5, Screen.width * 18.3f / 50, Screen.height * 9 / 20);
		Rect fireRect = new Rect(Screen.width * 2f / 3, Screen.height * 3.5f / 5, Screen.width * 18.3f / 50, Screen.height * 9 / 20);
		
		GUI.Box (waterRect, "", water);
		GUI.Box (earthRect, "", earth);
		GUI.Box (fireRect, "", fire);

		GUI.Box (new Rect(Screen.width / 20, Screen.height / 25, Screen.width / 3, Screen.height / 15), "Current Pop: "+currentPop.ToString()+" Min Pop: "+minPop.ToString()+" Time: "+Mathf.RoundToInt(Time.time).ToString(), style);
		
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
		
		if (Time.timeSinceLevelLoad == 0) Instantiate (blueTriangle);
		if (Time.timeSinceLevelLoad == .1f) Instantiate (blueTriangle);
		if (Time.timeSinceLevelLoad == .2f) Instantiate (blueTriangle);
		if (Time.timeSinceLevelLoad == .3f) Instantiate (blueTriangle);
		if (Time.timeSinceLevelLoad == .4f) Instantiate (blueTriangle);
		if (Time.timeSinceLevelLoad == .5f) Instantiate (blueTriangle);
		if (Time.timeSinceLevelLoad == .6f) Instantiate (blueTriangle);
		if (Time.timeSinceLevelLoad == .7f) Instantiate (blueTriangle);
		if (Time.timeSinceLevelLoad == .8f) Instantiate (blueTriangle);
		if (Time.timeSinceLevelLoad == .9f) Instantiate (blueTriangle);
		if (Time.timeSinceLevelLoad == 1f) Instantiate (blueTriangle);
		
		if (Time.time - timer >= .75 && counter < startingPop)
		{
			int random = Random.Range (0, Application.loadedLevel);
			if (random == 0) Instantiate (blueTriangle);
			if (random == 1) Instantiate (orangeTriangle);
			if (random == 2) Instantiate (greenTriangle);
			counter += 1;
		}
		
		transform.Rotate(Vector3.forward * Time.deltaTime * 10);		
		currentPop = GameObject.FindGameObjectsWithTag("Inhabitant").Length;
		
		if (currentPop == 0 && Time.timeSinceLevelLoad > 2.0f)
		{
			Application.LoadLevel(4);
			PlayerPrefs.SetInt("My Time", Mathf.RoundToInt(Time.timeSinceLevelLoad));
		}
	}
}
