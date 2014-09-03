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
	
	float blueTimer;
	float orangeTimer;
	float greenTimer;

	// Use this for initialization
	void Start () {
		bar_col = bar.GetChild (1);
		one = bar_col.GetChild(0);
		two = bar_col.GetChild(1);
		
		blueTimer = Time.time;
		orangeTimer = Time.time;
		greenTimer = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 asdf = new Vector2 (bar_col.position.x, bar_col.position.y);
		if (Physics2D.OverlapPoint (asdf)) 
		{
			one.particleSystem.enableEmission=true;
			two.particleSystem.enableEmission=true;
			if (transform.parent.parent.name == "target_green" && Time.time - greenTimer > .25f)
			{
				Instantiate (green);
				greenTimer = Time.time;
			}
			if (transform.parent.parent.name == "target_blue" && Time.time - blueTimer > .25f)
			{
				Instantiate(blue);
				blueTimer = Time.time;
			}
			if (transform.parent.parent.name == "target_orange" && Time.time - orangeTimer > .25f)
			{
				Instantiate(orange);
				orangeTimer = Time.time;
			}

		} 
		else 
		{
			one.particleSystem.enableEmission=false;
			two.particleSystem.enableEmission=false;
		}

	}


}
