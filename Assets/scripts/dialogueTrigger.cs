using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogueTrigger : MonoBehaviour
{
	//dialogue i want to display
    public Dialogue dialogue;
	
	//check if previous dialogue is done
	public dialogueManager diaDone;
	
	void Update()
	{
		
		if (diaDone.dialogueEnded == true)
			{
				FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
		
				gameObject.SetActive(false);
			}
	}
}
