using UnityEngine;
using System.Collections;

public class playercontrol : MonoBehaviour {


	// C: change all the publics to global
	// and set them in Start

	// each of the bars we want to move
	public Transform blue;
	public Transform green;
	public Transform orange;

	// start and end points of bars
	public Transform blue_next;
	public Transform blue_last;
	public Transform green_next;
	public Transform green_last;
	public Transform orange_next;
	public Transform orange_last;


	// speeds and speed decay
	public float speed;
	public float slow;

	public Transform cheat1;
	public Transform cheat2;
	public Transform cheat3;
	public float cheatN;

	// not quite sure what this is
	public bool activate = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// old code
		/*
				if (activate == true || Input.GetKey (KeyCode.Space)) {	
						float step = speed * Time.deltaTime;
						transform.position = Vector3.MoveTowards (transform.position, next.position, step);
				} else {
						float step = slow * Time.deltaTime;
						transform.position = Vector3.MoveTowards (transform.position, last.position, step);
				}
		*/
		float step_up = speed * Time.deltaTime;
		float step_down = slow * Time.deltaTime;


		if (Input.GetKey (KeyCode.Z)) {
			blue.position = Vector3.MoveTowards (blue.position, blue_next.position, step_up);
		} 
		else {
			blue.position = Vector3.MoveTowards (blue.position, blue_last.position, step_down);
		}

		if (Input.GetKey (KeyCode.X)) {
			orange.position = Vector3.MoveTowards (orange.position, orange_next.position, step_up);
		} 
		else {
			orange.position = Vector3.MoveTowards (orange.position, orange_last.position, step_down);
		}

		if (Input.GetKey (KeyCode.C)) {
			green.position = Vector3.MoveTowards (green.position, green_next.position, step_up);
		} 
		else {
			green.position = Vector3.MoveTowards (green.position, green_last.position, step_down);
		}
		// CHEAT MODE
		if (Input.GetKey (KeyCode.Space)) {	
			blue.position = Vector3.MoveTowards (blue.position, cheat1.position, step_up*cheatN);
			orange.position = Vector3.MoveTowards(orange.position, cheat2.position,step_up*cheatN);
			green.position = Vector3.MoveTowards(green.position, cheat3.position,step_up*cheatN);

		} 
	}
}
