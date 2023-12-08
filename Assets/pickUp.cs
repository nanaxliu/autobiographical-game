using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
	public GameObject stuff;
	bool enteredPickUpArea = false;
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		enteredPickUpArea = true;
	}
	
	void Update()
	{
		if ((enteredPickUpArea == true) && Input.GetKeyDown(KeyCode.X))
		{
			Debug.Log("picked up");
			stuff.gameObject.SetActive(false);
			//also play a sound eventually
		}
	}
	
}
