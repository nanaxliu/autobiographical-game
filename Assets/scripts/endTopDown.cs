using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endTopDown : MonoBehaviour
{
	public Dialogue dialogue;
	public dialogueManager diaDone;
	public string LevelIndex;
	
	bool enteredTPArea = false;
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
		
		enteredTPArea = true;
		
	}
	
	private void OnTriggerExit2D(Collider2D other)
	{
		FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
		
		enteredTPArea = false;
		
	}
	
	void Update()
	{
		if (diaDone.dialogueEnded == true && enteredTPArea == true)
		{
			SceneManager.LoadScene(LevelIndex, LoadSceneMode.Single);	
		}
	}
}
