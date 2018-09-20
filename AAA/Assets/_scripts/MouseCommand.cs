using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCommand : MonoBehaviour {

	// Variables
	public GameObject smileyPE;
	public int time;

	private Vector3 mousePos;

	private void Start()
	{
		mousePos = Input.mousePosition;
	}

	void FollowMouse()
	{
		// For Instantiating Use Quaternion.Identity
	}


}