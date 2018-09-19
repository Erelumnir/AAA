using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartAnimation : MonoBehaviour {

	// Variables
	public GameObject heartPE;
	public int time;

	public void PlayAnim()
	{
		GameObject heartInst = (GameObject)Instantiate(heartPE);
		Destroy(heartInst, time);
	}
}
