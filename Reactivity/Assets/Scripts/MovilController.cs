﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovilController : MonoBehaviour {

	public Transform target;
	public float movSpeed;

	private Vector3 start, end;
	// Use this for initialization
	void Start () {
		if(target != null){
			target.parent = null;
			start = transform.position;
			end = target.position;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		if (target != null) {
			float fixedSpeed = movSpeed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, target.position, fixedSpeed);
		}
	
		if(transform.position == target.position){
			target.position = (target.position == start) ? end : start;

		}
	}
}
