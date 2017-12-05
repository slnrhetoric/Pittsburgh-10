using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour {

	public string levelToLoad;

	public string exitPoint;

	private PlayerMovement thePlayer;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerMovement> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {

		if(other.gameObject.name == "player")
		{
			SceneManager.LoadScene (levelToLoad);
			thePlayer.startPoint = exitPoint;
		}
	}
}
