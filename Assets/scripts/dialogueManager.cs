using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class dialogueManager : MonoBehaviour
{
	
	public TextMeshProUGUI nameText;
	public TextMeshProUGUI dialogueText;
	
	public Animator animator;
	
	private Queue<string> sentences;
	
	public bool dialogueEnded = true;
	
	public bool IsRunning;
	public float typeSpeed = 0.03f;
	
    void Start()
    {
		dialogueEnded = false;
		
        sentences = new Queue<string>();
    }
	
	public void StartDialogue(Dialogue dialogue)
	{
		dialogueEnded = false;
		
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("closet"))
		{
			GameObject varGameObject = GameObject.FindWithTag("Player");

			varGameObject.GetComponent<topDownPlayer>().enabled = false;
		}
		
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("bedroom"))
		{
			GameObject varGameObject = GameObject.FindWithTag("Player");

			varGameObject.GetComponent<player>().enabled = false;
		}
		
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("hallway"))
		{
			GameObject varGameObject = GameObject.FindWithTag("Player");

			varGameObject.GetComponent<player>().enabled = false;
		}
		
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("hallway2"))
		{
			GameObject varGameObject = GameObject.FindWithTag("Player");

			varGameObject.GetComponent<player>().enabled = false;
		}
		
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
	
	public void Stop()
	{
		typeSpeed = 0f;
		
	}
	
	public void returnSpeed()
	{
		typeSpeed = 0.03f;
	}
	
	IEnumerator TypeSentence (string sentence)
	{
		IsRunning = true;
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("xhay"))
		{
			yield return new WaitForSeconds(0.3f);
		}
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("901"))
		{
			yield return new WaitForSeconds(0.3f);
		}
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("cats"))
		{
			yield return new WaitForSeconds(0.3f);
		}
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("grandma"))
		{
			yield return new WaitForSeconds(0.3f);
		}
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("goodbyeGZ"))
		{
			yield return new WaitForSeconds(0.3f);
		}
			
		else
		{
			yield return new WaitForSeconds(0.03f);
		}
		
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return new WaitForSeconds(typeSpeed);
		}
		IsRunning = false;
	}
	
	void EndDialogue()
	{
		animator.SetBool("IsOpen", false );
		
		dialogueEnded = true;
		
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("closet"))
		{
			GameObject varGameObject = GameObject.FindWithTag("Player");

			varGameObject.GetComponent<topDownPlayer>().enabled = true;
		}
		
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("bedroom"))
		{
			GameObject varGameObject = GameObject.FindWithTag("Player");

			varGameObject.GetComponent<player>().enabled = true;
		}
		
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("hallway"))
		{
			GameObject varGameObject = GameObject.FindWithTag("Player");

			varGameObject.GetComponent<player>().enabled = true;
		}
		
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("hallway2"))
		{
			GameObject varGameObject = GameObject.FindWithTag("Player");

			varGameObject.GetComponent<player>().enabled = true;
		}

		
	}

}
