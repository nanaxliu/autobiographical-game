using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
	public GameObject stuff;
	bool enteredPickUpArea = false;
	
	public AudioSource audioPlayer;
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		enteredPickUpArea = true;
	}
	
	private void OnTriggerExit2D(Collider2D other)
	{
		enteredPickUpArea = false;
	}
	
	void Update()
	{
		if ((enteredPickUpArea == true) && Input.GetKeyDown(KeyCode.X))
		{
			stuff.gameObject.SetActive(false);
			audioPlayer.Play();
		}
	}
	
}
