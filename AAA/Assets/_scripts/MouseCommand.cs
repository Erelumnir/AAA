using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCommand : MonoBehaviour {

	// Variables
	public float speed;
 
	void Update()
	{
		transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"),0) * Time.deltaTime * speed);
	}

}