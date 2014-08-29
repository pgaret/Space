using UnityEngine;
using System.Collections;

public class playercontrol : MonoBehaviour {

	public Transform next;
	public Transform last;
	public float speed;
	public float slow;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {	
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, next.position, step);
		} else 
		{
			float step = slow * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position,last.position,step);
		}
	}
}
