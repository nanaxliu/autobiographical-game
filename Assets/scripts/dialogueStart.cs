using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueStart : MonoBehaviour
{
	
	public Dialogue dialogue;
	
	void Update()
	{

			FindObjectOfType<dialogueManager>().StartDialogue(dialogue);

			gameObject.SetActive(false);

	}
}
