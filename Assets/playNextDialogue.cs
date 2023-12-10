using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playNextDialogue : MonoBehaviour
{
	//dialogue i want to display next
    public Dialogue dialogue;
	
	//check if previous dialogue is done
	public dialogueManager diaDone;
	
	void Update()
	{
		if (diaDone.dialogue1Ended == true)
			{
				FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
		
				gameObject.SetActive(false);
			}
	}
}
