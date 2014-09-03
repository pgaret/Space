using UnityEngine;
using System.Collections;

public class Inhabitants : MonoBehaviour {

	private float time;
	private GameObject[] spots;
	private GameObject[] inhabitants;
	
	// Use this for initialization
	void Start ()
	{
		spots = GameObject.FindGameObjectsWithTag("Spot");
		inhabitants = GameObject.FindGameObjectsWithTag("Inhabitant");
		int random = Random.Range(0, spots.Length);

		if (inhabitants.Length < spots.Length)
		{
			for (int i = 0; i < inhabitants.Length; i++)
			{
				if (inhabitants[i].transform.position == spots[random].transform.position)
				{
					i = -1;
					random = Random.Range(0, spots.Length);
				}
			}
		}
		transform.position = spots[random].transform.position;
		transform.tag = "Inhabitant";
		time = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
	{	
		if (Time.time - time > 1.0f) Destroy(gameObject);
	}
	
}
