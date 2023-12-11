using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    public dialogueManager diaDone;
	public string LevelIndex;
	
	void Update()
	{
		if (diaDone.dialogueEnded == true)
		{
			SceneManager.LoadScene(LevelIndex, LoadSceneMode.Single);
		}
	}
}
