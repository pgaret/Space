using UnityEngine;
using System.Collections;

public class score_check : MonoBehaviour {

	// whoops have to go back and fix this function
	// so that it is more compatable

	public Transform bar;
	public Transform orange;
	public Transform blue;
	public Transform green;
	
	Transform bar_col;
	Transform one;
	Transform two;

	// Use this for initialization
	void Start () {
		bar_col = bar.GetChild (1);
		one = bar_col.GetChild(0);
		two = bar_col.GetChild(1);
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 asdf = new Vector2 (bar_col.position.x, bar_col.position.y);
		if (Physics2D.OverlapPoint (asdf)) 
		{
			one.particleSystem.enableEmission=true;
			two.particleSystem.enableEmission=true;
			if (transform.parent.parent.name == "target_green") Instantiate (green);
			if (transform.parent.parent.name == "target_blue") Instantiate(blue);
			if (transform.parent.parent.name == "target_orange") Instantiate(orange);

		} 
		else 
		{
			one.particleSystem.enableEmission=false;
			two.particleSystem.enableEmission=false;
		}

	}


}
