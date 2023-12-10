using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backtohallway : MonoBehaviour
{
	public string LevelIndex;
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		SceneManager.LoadScene(LevelIndex, LoadSceneMode.Single);		
	}
}
