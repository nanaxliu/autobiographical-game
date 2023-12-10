using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatePlayer : MonoBehaviour
{
    void Update()
    {
		GameObject varGameObject = GameObject.FindWithTag("Player");

		varGameObject.GetComponent<player>().enabled = true;
    }
}
