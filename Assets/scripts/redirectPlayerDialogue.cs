using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redirectPlayerDialogue : MonoBehaviour
{
	public GameObject thing1;
	public GameObject thing2;
	
	public GameObject stuff1;
	public GameObject stuff2;
	
	public Dialogue dialogue;
	
	void Update()
	{
		if (thing1.gameObject.activeSelf == false && stuff1.gameObject.activeSelf == true && thing2.gameObject.activeSelf == false && stuff2.gameObject.activeSelf == true)
		{
			FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
			gameObject.SetActive(false);
		}
	}
}
