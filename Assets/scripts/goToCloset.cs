using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToCloset : MonoBehaviour
{
	public string LevelIndex;
	
	public bool wentToCloset = false;
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("hallway"))
		{
			wentToCloset = true;
			SceneManager.LoadScene(LevelIndex, LoadSceneMode.Single);
		}
	}
}
