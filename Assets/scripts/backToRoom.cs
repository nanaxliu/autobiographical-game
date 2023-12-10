using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backToRoom : MonoBehaviour
{
	public Dialogue dialogue;
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
			
		FindObjectOfType<dialogueManager>().StartDialogue(dialogue);

	}
}