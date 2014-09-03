using UnityEngine;
using System.Collections;

public class targetOscilation : MonoBehaviour {
		
	float curr_time;
	float goal_time;

	public Transform target;
	public Transform next;
	public Transform last;

	bool up_dir;
	float temp = 0.75f; // for speed of thing

	// new vecs higher
	Vector3 next2 = new Vector3();
	Vector3 last2 = new Vector3();

	// Use this for initialization
	void Start () {
		curr_time = 0f;
		goal_time = Random.Range (1f, 3f);
		up_dir = true;

		next2 = new Vector3 (next.position.x, next.position.y, -2f);
		last2= new Vector3(last.position.x, last.position.y, -2f);
	}
	
	// Update is called once per frame
	void Update () {
	
		curr_time += Time.deltaTime;

		// check if random time has been met

		if (goal_time - curr_time >= 0f)
		{
			if(up_dir)
			{
				//move towards next
				transform.position = Vector3.MoveTowards (transform.position, next2 , temp*Time.deltaTime);
			}
			else
			{
				//move towards last
				transform.position = Vector3.MoveTowards (transform.position, last2, temp*Time.deltaTime);
			}
		}
		else
		{
			up_dir = !up_dir;
			goal_time = Random.Range(.25f,2f);
			curr_time = 0f; 	
		}
	}
	
}
