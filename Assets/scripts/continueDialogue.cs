using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continueDialogue : MonoBehaviour
{
	public GameObject dialogueBox;
		
	public int dialogueClose;
	
	public dialogueManager diaDone;

	void Update()
	{
		if (diaDone.IsRunning == true && Input.GetKeyDown(KeyCode.Space))
		{
			FindObjectOfType<dialogueManager>().Stop();
			
		}
		
		if (diaDone.IsRunning == false && dialogueBox.transform.position.y > dialogueClose && Input.GetKeyDown(KeyCode.Space))
		{
			FindObjectOfType<dialogueManager>().returnSpeed();
			FindObjectOfType<dialogueManager>().DisplayNextSentence();
		}
	}
}
