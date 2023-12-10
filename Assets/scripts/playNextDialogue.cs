using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playNextDialogue : MonoBehaviour
{
	//dialogue i want to display next
    public Dialogue dialogue;
	
	//check if previous dialogue is done
	public dialogueManager diaDone;
	
	//so you can enable next dialogue gameobject
	public GameObject nextDialogue;
	
	void Update()
	{
		
		if (diaDone.dialogueEnded == true)
			{
				FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
				
				if (diaDone.dialogueEnded == false)
				{
					Debug.Log("not done talking");
						if (diaDone.dialogueEnded == false)
						{
							nextDialogue.gameObject.SetActive(true);
							
							
							gameObject.SetActive(false);
						}
				}
			}
			
	}
}
