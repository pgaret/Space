using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	public Transform title;
	public GUIStyle style;
	
	float timer;
	bool onGUI = false;
	
	// Use this for initialization
	void Start ()
	{
		Instantiate(title);
		timer = Time.time;
//		title.localScale = new Vector2(1, 1);
//		
//		float width = title.renderer.bounds.size.x;
//		float height = title.renderer.bounds.size.y;
//		
//		float worldscreenHeight = Camera.main.orthographicSize * 2.0f;
//		float worldscreenWidth = worldscreenHeight / Screen.height * Screen.width;
//		
//		title.localScale = new Vector2(worldscreenWidth / width, worldscreenHeight / height);
//		
//		Instantiate(title);
	}
	
	void OnGUI()
	{
		Rect rect1 = new Rect(Screen.width * 2 / 5, Screen.height / 5, Screen.width / 8, Screen.height / 7);
		Rect rect2 = new Rect(Screen.width * 2 / 5, Screen.height * 2.25f / 5, Screen.width / 8, Screen.height / 7);
		Rect rect3 = new Rect(Screen.width * 2 / 5, Screen.height * 3.5f / 5, Screen.width / 8, Screen.height / 7);
		
		if (onGUI == true)
		{
			GUI.Box (rect1, "Easy", style);
			GUI.Box (rect2, "Medium", style);
			GUI.Box (rect3, "Hard", style);
		}
		
		Vector3 pos = Input.mousePosition;
		pos.y = Screen.height - pos.y;
		
		if (Input.GetMouseButton(0) && rect1.Contains(pos)) Application.LoadLevel (1);
		if (Input.GetMouseButton(0) && rect2.Contains(pos)) Application.LoadLevel (2);
		if (Input.GetMouseButton(0) && rect3.Contains(pos)) Application.LoadLevel (3);
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Time.time - timer >= 1.25f) onGUI = true;
	}
}
