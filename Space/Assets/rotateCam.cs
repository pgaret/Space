﻿using UnityEngine;
using System.Collections;

public class rotateCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (transform.position,Vector3.forward, .25f);
	}
}
