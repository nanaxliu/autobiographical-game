using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour
{
    public Dialogue dialogue;
	
	void Update()
	{
		GameObject varGameObject = GameObject.FindWithTag("Player");

		varGameObject.GetComponent<player>().enabled = false;
		
		if (Input.GetKeyDown(KeyCode.Space))
		{
			
			FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
		
			gameObject.SetActive(false);
		}
	}
}
