using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continueDialogue : MonoBehaviour
{
	public GameObject dialogueBox;
		
	public int dialogueClose;

	void Update()
	{
		if (dialogueBox.transform.position.y > dialogueClose && Input.GetKeyDown(KeyCode.Space))
		{
			FindObjectOfType<dialogueManager>().DisplayNextSentence();
		}
	}
}
