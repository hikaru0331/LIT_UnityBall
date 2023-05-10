﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
	public GameObject player;
	Vector3 pivotDirection;
	public float rotateSpeed = 3.0f;

	// Use this for initialization
	void Start()
	{
		pivotDirection = new Vector3(0, 0, 1);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.RotateAround(player.transform.position, pivotDirection, -rotateSpeed);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
            transform.RotateAround(player.transform.position, pivotDirection, rotateSpeed);
        }
	}
}