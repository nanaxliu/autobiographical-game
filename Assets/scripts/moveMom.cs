using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMom : MonoBehaviour
{
	public GameObject lastDialogue;
	
	Animator animator;
	
	public dialogueManager diaDone;
	
	public GameObject momm;
	
	void Start()
	    {
	        animator = gameObject.GetComponent<Animator>();
        
	    }
	
    void Update()
    {
		GameObject varGameObject = GameObject.FindWithTag("Player");

		varGameObject.GetComponent<player>().enabled = false;
		
		if (lastDialogue.gameObject.activeSelf == true && diaDone.dialogueEnded == true)
		{
	        animator.SetBool("momWalking", true);
		
			transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;
			
			if (momm.transform.position.x < -13)
			{
				gameObject.SetActive(false);
				
				varGameObject.GetComponent<player>().enabled = true;
			}

		}

    }
}
