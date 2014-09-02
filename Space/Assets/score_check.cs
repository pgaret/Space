using UnityEngine;
using System.Collections;

public class score_check : MonoBehaviour {

	// whoops have to go back and fix this function
	// so that it is more compatable

	public Transform bar_blue;
	Transform one;
	Transform two;

	// Use this for initialization
	void Start () {
		one = bar_blue.GetChild(0);
		two = bar_blue.GetChild(1);
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 asdf = new Vector2 (bar_blue.position.x, bar_blue.position.y);
		if (Physics2D.OverlapPoint (asdf)) 
		{
			one.particleSystem.enableEmission=true;
			two.particleSystem.enableEmission=true;
			print ("collision");

		} 
		else 
		{
			one.particleSystem.enableEmission=false;
			two.particleSystem.enableEmission=false;
		}

	}


}
