using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leaveRoom : MonoBehaviour
{
	public GameObject stuff1;
	public GameObject stuff2;
	
	public Dialogue dialogue;
	public Dialogue dialogue2;
	
	public string LevelIndex;
	
	public bool doneTalking = false;
	public dialogueManager diaDone;
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (stuff1.gameObject.activeSelf == false || stuff2.gameObject.activeSelf == false)
		{
			
			FindObjectOfType<dialogueManager>().StartDialogue(dialogue);

		}
		
		if (stuff1.gameObject.activeSelf == true && stuff2.gameObject.activeSelf == true)
		{

			FindObjectOfType<dialogueManager>().StartDialogue(dialogue2);
			
			doneTalking = true;
		}	
		
	}
	
	void Update()
	{
		if (stuff1.gameObject.activeSelf == true && stuff2.gameObject.activeSelf == true && doneTalking == true && diaDone.dialogueEnded == true)
		{
			SceneManager.LoadScene(LevelIndex, LoadSceneMode.Single);
		}
	}
}