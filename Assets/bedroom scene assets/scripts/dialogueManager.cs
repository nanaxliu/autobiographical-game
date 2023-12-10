using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dialogueManager : MonoBehaviour
{
	
	public TextMeshProUGUI nameText;
	public TextMeshProUGUI dialogueText;
	
	public Animator animator;
	
	private Queue<string> sentences;
	
	public bool dialogueEnded = true;
	
    void Start()
    {
		dialogueEnded = false;
		
        sentences = new Queue<string>();
    }
	
	public void StartDialogue(Dialogue dialogue)
	{
		dialogueEnded = false;
		
		GameObject varGameObject = GameObject.FindWithTag("Player");

		varGameObject.GetComponent<player>().enabled = false;
		
		animator.SetBool("IsOpen", true);
		
		nameText.text = dialogue.name;
		
		sentences.Clear();
		
		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}
		
		DisplayNextSentence();
		
	}
	
	public void DisplayNextSentence()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}
		
		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}
	
	IEnumerator TypeSentence (string sentence)
	{
		yield return new WaitForSeconds(0.03f);
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return new WaitForSeconds(0.03f);
		}
	}
	
	void EndDialogue()
	{
		animator.SetBool("IsOpen", false );
		
		dialogueEnded = true;
		
		GameObject varGameObject = GameObject.FindWithTag("Player");

		varGameObject.GetComponent<player>().enabled = true;
		
		
	}

}
