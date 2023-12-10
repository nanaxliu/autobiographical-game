using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putDown : MonoBehaviour
{
	public GameObject thing1;
	public GameObject thing2;
	
	public GameObject stuff1;
	public GameObject stuff2;
	
	public AudioSource audioPlayer;
	
	bool enteredPutDownArea = false;
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		enteredPutDownArea = true;
	}
	
	private void OnTriggerExit2D(Collider2D other)
	{
		enteredPutDownArea = false;
	}
	
	void Update()
	{
		if ((enteredPutDownArea == true) && Input.GetKeyDown(KeyCode.X) && thing1.gameObject.activeSelf == false && stuff1.gameObject.activeSelf == false)
		{
			stuff1.gameObject.SetActive(true);
			audioPlayer.Play();
		}
		
		if ((enteredPutDownArea == true) && Input.GetKeyDown(KeyCode.X) && thing2.gameObject.activeSelf == false && stuff2.gameObject.activeSelf == false)
		{
			stuff2.gameObject.SetActive(true);
			audioPlayer.Play();
		}
	}
}
