using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaveRoom : MonoBehaviour
{
	public GameObject stuff1;
	public GameObject stuff2;
	
	public Dialogue dialogue;
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (stuff1.gameObject.activeSelf == false || stuff2.gameObject.activeSelf == false)
		{
			FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
		}
		
		if (stuff1.gameObject.activeSelf == true || stuff2.gameObject.activeSelf == true)
		{
			Debug.Log("left room");
		}
		
	}
}
