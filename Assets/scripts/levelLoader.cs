using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{
	public dialogueManager diaDone;
	public string LevelIndex;
	public Animator transition;
	public float transitionTime;

    // Update is called once per frame
    void Update()
    {
        if(diaDone.dialogueEnded == true)
		{
			LoadNextLevel();
		}
    }
	
	public void LoadNextLevel()
	{
		StartCoroutine(LoadLevel());
	}
	
	IEnumerator LoadLevel()
	{
		transition.SetTrigger("Start");
		
		yield return new WaitForSeconds(transitionTime);
		
		SceneManager.LoadScene(LevelIndex, LoadSceneMode.Single);
	}
	
}
