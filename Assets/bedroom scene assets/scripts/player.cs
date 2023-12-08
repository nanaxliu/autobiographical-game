using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
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
			characterRotation.y = 0f;
		}
		
		if (Input.GetKeyUp(KeyCode.RightArrow)) {
			animator.SetBool("isWalking", false);
		}
		
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
			
			animator.SetBool("isWalking", true);
			characterRotation.y = 180f;
		}
		
		if (Input.GetKeyUp(KeyCode.LeftArrow)) {
			animator.SetBool("isWalking", false);
		}
		
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
			
			animator.SetBool("isWalking", true);
			characterRotation.y = 0f;
		}
		
		if (Input.GetKeyUp(KeyCode.UpArrow)) {
			animator.SetBool("isWalking", false);
		}
		
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
			
			animator.SetBool("isWalking", true);
			characterRotation.y = 0f;
		}
		
		if (Input.GetKeyUp(KeyCode.DownArrow)) {
			animator.SetBool("isWalking", false);
		}
		
		transform.localRotation = characterRotation;
	}
}
