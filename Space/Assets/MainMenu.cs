using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	public Transform title;
	
	// Use this for initialization
	void Start ()
	{
		SpriteRenderer sr = title.GetComponent<SpriteRenderer>();
		
		title.localScale = new Vector2(1, 1);
		
		float width = title.renderer.bounds.size.x;
		float height = title.renderer.bounds.size.y;
		
		float worldscreenHeight = Camera.main.orthographicSize * 2.0f;
		float worldscreenWidth = worldscreenHeight / Screen.height * Screen.width;
		
		title.localScale = new Vector2(worldscreenWidth / width, worldscreenHeight / height);
		
		Instantiate(title);
	}
	
	void OnGUI()
	{
		if (GUI.Button (new Rect(Screen.width / 3, Screen.height * 3 / 4, Screen.width / 3, Screen.height / 10), "Play")) Application.LoadLevel(1);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
