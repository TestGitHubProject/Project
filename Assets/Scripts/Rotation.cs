﻿using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.E))
		{
			transform.RotateAround(transform.position, Vector3.up, rotationSpeed);
		}
	}
}
