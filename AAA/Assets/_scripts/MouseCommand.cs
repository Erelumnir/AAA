using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCommand : MonoBehaviour {

	// Variables
	public GameObject smileyPE;
	public int time;
	public Vector3 offset;

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				GameObject smileyInst = (GameObject)Instantiate(smileyPE, hit.point - offset, Quaternion.identity);
				Destroy(smileyInst, time);
			}
		}
	}
}