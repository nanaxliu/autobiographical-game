using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topDownPlayer : MonoBehaviour
{
	public float speed = 0f;

	Animator animator;

	void Start()
	    {
	        animator = gameObject.GetComponent<Animator>();
        
	    }

    // Update is called once per frame
    void Update()
    {
		Quaternion characterRotation = transform.localRotation;

        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
			
			animator.SetBool("isWalking", true);
			animator.SetBool("walkingUp", false);
			animator.SetBool("walkingDown", false);
			animator.SetBool("idleRight", false);
			animator.SetBool("idleLeft", false);
			animator.SetBool("idleUp", false);
			characterRotation.y = 0f;
			characterRotation.x = 0f;
			characterRotation.z = 180f;
		}
		
		if (Input.GetKeyUp(KeyCode.RightArrow)) {
			animator.SetBool("isWalking", false);
			animator.SetBool("walkingUp", false);
			animator.SetBool("walkingDown", false);
			animator.SetBool("idleRight", true);
			animator.SetBool("idleLeft", false);
			animator.SetBool("idleUp", false);
			characterRotation.y = 0f;
			characterRotation.x = 0f;
			characterRotation.z = 0f;
		}
		
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
			
			animator.SetBool("isWalking", true);
			animator.SetBool("walkingUp", false);
			animator.SetBool("walkingDown", false);
			animator.SetBool("idleRight", false);
			animator.SetBool("idleLeft", false);
			animator.SetBool("idleUp", false);
			characterRotation.y = 0f;
			characterRotation.x = 0f;
			characterRotation.z = 0f;
		}
		
		if (Input.GetKeyUp(KeyCode.LeftArrow)) {
			animator.SetBool("isWalking", false);
			animator.SetBool("walkingUp", false);
			animator.SetBool("walkingDown", false);
			animator.SetBool("idleRight", false);
			animator.SetBool("idleLeft", true);
			animator.SetBool("idleUp", false);
		}
		
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
			
			animator.SetBool("isWalking", false);
			animator.SetBool("walkingUp", true);
			animator.SetBool("walkingDown", false);
			animator.SetBool("idleRight", false);
			animator.SetBool("idleLeft", false);
			animator.SetBool("idleUp", false);
			characterRotation.x = 0f;
			characterRotation.z = 0f;
			characterRotation.y = 0f;
		}
		
		if (Input.GetKeyUp(KeyCode.UpArrow)) {
			animator.SetBool("isWalking", false);
			animator.SetBool("walkingUp", false);
			animator.SetBool("walkingDown", false);
			animator.SetBool("idleRight", false);
			animator.SetBool("idleLeft", false);
			animator.SetBool("idleUp", true);
		}
		
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
			
			animator.SetBool("isWalking", false);
			animator.SetBool("walkingUp", false);
			animator.SetBool("walkingDown", true);
			characterRotation.x = 0f;
			characterRotation.z = 0f;
			characterRotation.y = 0f;
		}
		
		if (Input.GetKeyUp(KeyCode.DownArrow)) {
			animator.SetBool("isWalking", false);
			animator.SetBool("walkingUp", false);
			animator.SetBool("walkingDown", false);
			animator.SetBool("idleRight", false);
			animator.SetBool("idleLeft", false);
			animator.SetBool("idleUp", false);
		}
		
		transform.localRotation = characterRotation;
	}
}