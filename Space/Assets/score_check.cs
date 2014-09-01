using UnityEngine;
using System.Collections;

public class score_check : MonoBehaviour {

	public Transform bar_blue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 asdf = new Vector2 (bar_blue.position.x, bar_blue.position.y);
		if (Physics2D.OverlapPoint (asdf))
						print (";masdf");
	}


}
