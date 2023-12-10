using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour
{
    public Dialogue dialogue;
	
	public GameObject nextDialogue;
	
	void Update()
	{
		GameObject varGameObject = GameObject.FindWithTag("Player");

		varGameObject.GetComponent<player>().enabled = false;
		
		if (Input.GetKeyDown(KeyCode.Space))
		{
			
			FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
			
			nextDialogue.gameObject.SetActive(true);
		
			gameObject.SetActive(false);
		}
	}
}
